using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TaskApi.Models;
using TaskApi.TaskDbContext;

namespace TaskApi.Repository
{
	public class AuthRespository : IAuthService
	{

		private readonly DataDbContext _JwtService;
		private readonly IConfiguration _Configuration;
		public AuthRespository(DataDbContext JwtService, IConfiguration Configuration)
        {
			_JwtService = JwtService;
			_Configuration = Configuration;

		}
        public User AddUser(User user)
		{
			var addedUser = _JwtService.User.Add(user);
			_JwtService.SaveChanges();
			return addedUser.Entity;
		}

		public string Login(LoginRequest loginRequest)
		{
			if (loginRequest.UserName != null && loginRequest.Password != null) 
			{
				var user = _JwtService.User.SingleOrDefault(s => s.Email == loginRequest.UserName && s.Password == loginRequest.Password);
				if (user != null) 
				{
					var claim = new[] {
                               new Claim(JwtRegisteredClaimNames.Sub, _Configuration["Jwt:Subject"]),
                               new Claim("Id", user. Id. ToString()),
                               new Claim("UserName", user. Name),
						       new Claim("Email", user.Email)
					   };

					var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Configuration["Jwt:Key"]));
					var signIn = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

					var token = new JwtSecurityToken(_Configuration["Jwt:Issuer"],
					  _Configuration["Jwt:Audience"],claim
					 ,
					  expires: DateTime.Now.AddMinutes(120),
					  signingCredentials: signIn);
					var jwtToken= new JwtSecurityTokenHandler().WriteToken(token);
					return jwtToken;
				}
				else
				{
					throw new Exception("user is not valid");
				}
			}
			else
			{
				throw new Exception("credential is not valid");
			}
		}
	}
}
