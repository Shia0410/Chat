using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

void ConfigureServices(IServiceCollection services)
{
    services.AddCors(options =>
    {
        options.AddPolicy("MyPolicy", // A catchy policy name...
            builder =>
            {
                builder
                    .WithOrigins("*")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
    });
}

ConfigureServices(builder.Services);
var app = builder.Build();

app.UseCors("MyPolicy");
app.UseStaticFiles();
app.UseRouting();


app.Run();

