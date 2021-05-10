using System;
namespace blogum_db.dtos
{
    public interface IBaseDto
    {
        public long? Id { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool IsActive { get; set; }
    }

    public class BaseDto: IBaseDto
    {
        public BaseDto()
        { }

        public long? Id { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.Now;

        public DateTime ModifiedDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
    }
}
