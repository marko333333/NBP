var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRedis(builder.Configuration);
builder.Services.AddSingleton<PlaylistService>();
builder.Services.AddControllers();


var app = builder.Build();
app.MapControllers();
app.Run();