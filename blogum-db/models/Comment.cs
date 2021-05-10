using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogum_db.models
{
    [Table("Comments")]
    public class Comment : BaseEntity
    {
        public Comment()
        {
        }

        public string Content { get; set; }

        public long UserId { get; set; }

        public long PostId { get; set; }
    }
}
