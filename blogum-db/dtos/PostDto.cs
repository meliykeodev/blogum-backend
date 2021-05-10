using System;
namespace blogum_db.dtos
{
    public class PostDto: BaseDto
    {
        public PostDto()
        {
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ViewCount { get; set; }

        public int CategoryId { get; set; }
    }
}
