using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogum_db.models
{
    [Table("Categories")]
    public class Category : BaseEntity
    {
        public Category()
        {
        }

        [MinLength(1)]
        public string Name { get; set; }
    }
}
