using BookService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add HttpClient for external API
builder.Services.AddHttpClient("bookRecommendations", client =>
{
  client.BaseAddress = new Uri("https://openlibrary.org/");
  client.DefaultRequestHeaders.Accept.Clear();
  client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
});

// Add Swagger/OpenAPI support
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure CORS
builder.Services.AddCors(options =>
{
  options.AddDefaultPolicy(builder =>
  {
    builder.WithOrigins("http://localhost:4200") // Adjust this URL to match your frontend
           .AllowAnyHeader()
           .AllowAnyMethod();
  });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseDeveloperExceptionPage();
  app.UseSwagger();
  app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BookService API v1"));
}

app.UseHttpsRedirection();
app.UseCors(); // Enable CORS

app.UseAuthorization();

app.MapControllers();

app.Run();
