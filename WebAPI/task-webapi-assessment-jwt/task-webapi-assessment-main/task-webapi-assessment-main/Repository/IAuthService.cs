using TaskApi.Models;

namespace TaskApi.Repository
{
	public interface IAuthService
	{
		User AddUser(User user);

		string Login(LoginRequest loginRequest);
	}
}
