using dotMemo.DataBase;
using dotMemo.Entities;
using dotMemo.Interfaces;
using dotMemo.Repositories;
using dotMemo.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("PostgreSqlConnection");

// Controllers
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Services
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ICharacterService, CharacterService>();

builder.Services.AddDbContext<DataBaseContext>(options =>
    options.UseNpgsql(connectionString));


var app = builder.Build();
//Init DB Migration
//using(var scope = app.Services.CreateScope())
//{
//    var context = scope.ServiceProvider.GetRequiredService<DataBaseContext>();
//    Console.WriteLine(context);
//    context.Database.Migrate();
//} 

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
