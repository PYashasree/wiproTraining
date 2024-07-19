using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using TaskApi.Repository;
using TaskApi.TaskDbContext;

namespace TaskApi
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);

      builder.Services.AddDbContext<DataDbContext>(options =>
      {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQlConnection"));
      });

      builder.Services.AddScoped<ITaskRepository, TaskRepository>();
	  builder.Services.AddScoped<IAuthService, AuthRespository>();
	  builder.Services.AddControllers();
			builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
			.AddJwtBearer(options =>
			{
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					ValidIssuer = builder.Configuration["Jwt:Issuer"],
					ValidAudience = builder.Configuration["Jwt:Issuer"],
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
				};
			});


			var app = builder.Build();
     

      app.UseAuthorization();

      app.MapControllers();

      app.Run();
    }
  }
}
