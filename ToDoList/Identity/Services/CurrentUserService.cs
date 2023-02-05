using Application.Constants;
using Application.Contracts.Identity;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;


namespace Identity.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly ClaimsPrincipal _user;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _user = httpContextAccessor.HttpContext?.User!;
        }
        public string GetId()
        {
            return _user.Claims.FirstOrDefault(c => c.Type == CustomClaimTypes.Uid)?.Value!;
        }

        public string GetUserName()
        {
            return _user.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub)?.Value!;
        }
    }
}
