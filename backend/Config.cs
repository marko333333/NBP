using StackExchange.Redis;

public class RedisSettings
{
    public const string SectionName = "Redis";
    public string ConnectionString { get; set; } = "localhost:6379";
}

public static class Config
{
    public static IServiceCollection AddRedis(
        this IServiceCollection services, IConfiguration configuration)
    {
        var settings = configuration
            .GetSection(RedisSettings.SectionName)
            .Get<RedisSettings>() ?? new RedisSettings();

        services.AddSingleton<IConnectionMultiplexer>(_ =>
            ConnectionMultiplexer.Connect(settings.ConnectionString));

        services.AddSingleton<IDatabase>(sp =>
            sp.GetRequiredService<IConnectionMultiplexer>().GetDatabase());

        return services;
    }
}