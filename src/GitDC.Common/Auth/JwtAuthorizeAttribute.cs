using Microsoft.AspNetCore.Authorization;

namespace GitDC.Auth
{
    public class JwtAuthorizeAttribute : AuthorizeAttribute
    {
        public const string JwtAuthenticationScheme = "JwtAuthenticationScheme";

        public JwtAuthorizeAttribute()
        {
            this.AuthenticationSchemes = JwtAuthenticationScheme;
        }
    }
}
