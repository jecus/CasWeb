using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using BusinessLayer.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace WebDevelopment.Infrastructude.JWT
{
	public class JwtProvider : IJwtProvider
	{
		private readonly IConfiguration _configuration;

		public JwtProvider(IConfiguration configuration)
		{
			_configuration = configuration;
		}
		
		public string GenerateToken(UserView offer)
		{
			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:Secret"]));
			var handler = new JwtSecurityTokenHandler();
			var token = handler.CreateJwtSecurityToken(
				subject: new ClaimsIdentity(new GenericIdentity(""), new[]
					{
						new Claim("User", JsonConvert.SerializeObject(offer)),
					}
				),
				signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature),
				expires: DateTime.UtcNow.AddHours(12)
			);

			return handler.WriteToken(token);
		}

		public UserView GetUserFromToken(string token)
		{
			var key = Encoding.ASCII.GetBytes(_configuration["Authentication:Secret"]);
			var handler = new JwtSecurityTokenHandler();
			var tokenSecure = handler.ReadToken(token);
			var validations = new TokenValidationParameters
			{
				ValidateIssuerSigningKey = true,
				IssuerSigningKey = new SymmetricSecurityKey(key),
				ValidateIssuer = false,
				ValidateAudience = false
			};
			var claims = handler.ValidateToken(token, validations, out tokenSecure);

			if (tokenSecure.ValidTo < DateTime.UtcNow)
				return null;
			var json = claims.Claims.FirstOrDefault(i => i.Type == "User")?.Value;

			return JsonConvert.DeserializeObject<UserView>(json);
		}
	}
}