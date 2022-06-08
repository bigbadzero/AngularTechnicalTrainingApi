using AngularTechnicalTrainingApi.Data;
using AngularTechnicalTrainingApi.Data.Configurations;
using AngularTechnicalTrainingApi.Data.GenericRepository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("sqlConnection");
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddControllers();
builder.Services.AddControllers().AddNewtonsoftJson(op =>
                op.SerializerSettings.ReferenceLoopHandling =
                    ReferenceLoopHandling.Ignore);

builder.Services.AddCors(c => {
    c.AddPolicy("AllowAll", builder =>
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

});


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

app.UseCors("AllowAll");


app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
