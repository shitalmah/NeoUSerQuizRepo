using Microsoft.EntityFrameworkCore;
using QuizApp_API.Data;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowOrigin",
        builder =>
        {
            builder.AllowAnyOrigin()
                                .AllowAnyHeader()
                                .AllowAnyMethod();
        });
});
builder.Services.AddDbContext<USerDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("conn")));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(builder => builder
.AllowAnyHeader()
.AllowAnyMethod()
.SetIsOriginAllowed((host) => true)
.AllowCredentials());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
