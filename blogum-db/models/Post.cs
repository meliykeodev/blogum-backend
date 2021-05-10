using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace blogum_db.models
{
    [Table("Posts")]
    public class Post : BaseEntity
    {
        public Post()
        {
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ViewCount { get; set; }

        public long UserId { get; set; }

        public long CategoryId { get; set; }
    }
}
