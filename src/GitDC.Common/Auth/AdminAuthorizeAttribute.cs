using Microsoft.AspNetCore.Authorization;

namespace GitDC.Auth
{
    public class AdminAuthorizeAttribute : AuthorizeAttribute
    {
        public const string AdminAuthenticationScheme = "AdminAuthenticationScheme";

        public AdminAuthorizeAttribute()
        {
            AuthenticationSchemes = AdminAuthenticationScheme;
        }
    }
}
