using System;
using blogum_core.enums;

namespace blogum_db.dtos
{
    public class UserDto : BaseDto
    {
        public UserDto()
        {
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Ranks Rank { get; set; }
    }
}
