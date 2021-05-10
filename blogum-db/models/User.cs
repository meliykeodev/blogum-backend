using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using blogum_core.enums;

namespace blogum_db.models
{
    [Table("Users")]
    public class User : BaseEntity
    {
        public User()
        {
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

    }
}
