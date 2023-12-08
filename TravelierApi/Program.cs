using Microsoft.EntityFrameworkCore;
using TravelierApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = "Data Source=YASSIR;Initial Catalog=Travelier;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(connectionString);
});




builder.Services.AddScoped<IToursRepository, ToursRepository>();


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
