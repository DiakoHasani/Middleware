using Application.Extensions;
using Core.Extensions;
using Infrastructure.Extensions;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region InfrastructureLayer
builder.Services.ConfigDatabase();
builder.Services.ConfigDependencyInjectionInfrastructure();
#endregion

#region CoreLayer
builder.Services.ConfigAutoMapper();
builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
#endregion

#region ApplicationLayer
builder.Services.ConfigMemoryCache();
builder.Services.ConfigDependencyInjectionApplication();
#endregion

builder.Services.AddLogging(loggingBuilder =>
{
    loggingBuilder.AddSeq();
});

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
