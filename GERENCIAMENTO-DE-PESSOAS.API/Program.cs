using System.Text.Json.Serialization;
using GERENCIAMENTO_DE_PESSOAS.CORE.Interfaces.Repositorio;
using GERENCIAMENTO_DE_PESSOAS.CORE.Interfaces.Services;
using GERENCIAMENTO_DE_PESSOAS.DATA;
using GERENCIAMENTO_DE_PESSOAS.DATA.Repositorios;
using GERENCIAMENTO_DE_PESSOAS.MANAGER.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPessoasRepository, PessoasRepository>();
builder.Services.AddScoped<IPessoaService, PessoaService>();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var connectionString = builder.Configuration.GetConnectionString("Connection");

builder.Services.AddDbContext<GerenciamentoDbContext>(p => p.UseSqlServer(connectionString));

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
