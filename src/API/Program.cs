using Microsoft.OpenApi;
using GymApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

if(string.IsNullOrEmpty(ConnectionString))
    throw new Exception("Connection String 'DefaultConnection' não foi encontrada");

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseNpgsql(ConnectionString));

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(options =>
    {
        options.SwaggerDoc("v1", new OpenApiInfo
        {
            Version = "1.0",
            Title = "Gym-app",
            Description = "Um app que armazena e organiza fichas de treinos"
        });
    });
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

// faz as migrações automaticamente
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}


app.UseHttpsRedirection();

app.MapControllers();

app.Run();
