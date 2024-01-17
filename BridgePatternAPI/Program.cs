using BridgePatternAPI;
using BridgePatternAPI.Database;
using BridgePatternAPI.Mapping;
using BridgePatternAPI.Repositories.Abstractions;
using BridgePatternAPI.Repositories.Implementations;
using BridgePatternAPI.Services.HandleExceptions;
using BridgePatternAPI.Services.ModelServices.Abstraction;
using BridgePatternAPI.Services.ModelServices.Implementation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConsStr"));
});

// Handle exceptions in controllers
builder.Services.AddScoped<IHandleException, HandleException>();

// Devices
builder.Services.AddScoped<IDeviceRepo, DeviceRepo>();
builder.Services.AddScoped<IDeviceService, DeviceService>();

// Remotes
builder.Services.AddScoped<IRemoteRepo, RemoteRepo>();
builder.Services.AddScoped<IRemoteService, RemoteService>();

// AutoMapper
builder.Services.AddAutoMapper(typeof(ModelToResource));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

if (app.Environment.IsDevelopment()) {}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();