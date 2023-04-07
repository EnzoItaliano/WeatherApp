using WeatherAPIAdapter;
using WeatherApp.Contracts;
using WeatherForecast.Contracts;
using WeatherForecast.Services;

DotNetEnv.Env.TraversePath().Load();
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddSingleton<IOpenWeatherMapApiAdapter>(provider =>
{
    var apiKey = System.Environment.GetEnvironmentVariable("Open_Weather_Map_API_key");
    return new OpenWeatherMapApiAdapter(apiKey);
});
builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
