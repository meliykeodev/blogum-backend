using System;
namespace blogum_core.dtos
{
    public class AuthenticationDto
    {
        public AuthenticationDto()
        {
        }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
