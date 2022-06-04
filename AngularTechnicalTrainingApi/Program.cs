using AngularTechnicalTrainingApi.Data;
using AngularTechnicalTrainingApi.Data.Configurations;
using AngularTechnicalTrainingApi.Data.GenericRepository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("sqlConnection");
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddControllers();

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutoMapperConfiguration());
});

var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);


//dependency injections
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

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
