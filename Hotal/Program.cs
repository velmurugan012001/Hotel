global using Hotal.Model;
using HotelAss.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<HotalDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("OnetoManyCon")));
//var connectionstring = builder.Configuration.GetConnectionString("OnetoManyCon");
builder.Services.AddDbContext<HotelDbContext>(optionsAction: options => options.UseSqlServer(builder.Configuration.GetConnectionString(name: "OnetoManyCon")));
//builder.Services.AddScoped<IHotal,ServiesHotal>();
builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling =
    Newtonsoft.Json.ReferenceLoopHandling.Ignore;
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
