using System;
namespace blogum_core.dtos
{
    public class AuthToken
    {
        public AuthToken()
        {
        }

        public string Token { get; set; }

        public long UserId { get; set; }

        public DateTime ExpiredDate { get; set; } = DateTime.Now.AddHours(12);

        public bool HasExpired => ExpiredDate < DateTime.Now;
    }
}
