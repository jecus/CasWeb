using BusinessLayer.Views;

namespace WebDevelopment.Infrastructude.JWT
{
	public interface IJwtProvider
	{
		string GenerateToken(UserView offer);
		UserView GetUserFromToken(string token);
	}
}