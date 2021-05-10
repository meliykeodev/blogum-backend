using System;
namespace blogum_db.dtos
{
    public class CommentDto: BaseDto
    {
        public CommentDto()
        {
        }

        public string Content { get; set; }

        public long UserId { get; set; }

        public long PostId { get; set; }
    }
}
