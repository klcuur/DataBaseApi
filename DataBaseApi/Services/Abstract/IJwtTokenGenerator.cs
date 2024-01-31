using DataBaseApi.Models;

namespace DataBaseApi.Services.Abstract
{
    public interface IJwtTokenGenerator
    {
		Task<string> GenerateToken(AppUser user);
	}
}
