using Application;
using Application.Interfaces;
using Application.Repositories;
using Application.Services;
using Domain;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<StockDbContext>(o =>
{
    o.UseNpgsql(builder.Configuration.GetConnectionString("Connection"));
});
builder.Services.AddControllers(); 
builder.Services.AddTransient<IUploadService, UploadService>();
builder.Services.AddTransient<ISearchService, SearchService>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(typeof(AutomapperProfile));

var app = builder.Build();

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();