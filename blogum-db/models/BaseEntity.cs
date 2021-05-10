using System;
using System.ComponentModel.DataAnnotations;

namespace blogum_db.models
{
    public class BaseEntity: IBaseEntity
    {
        public BaseEntity()
        {
        }

        [Key]
        public long Id { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.Now;

        public DateTime ModifiedDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
    }

    public interface IBaseEntity
    {
        public long Id { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool IsActive { get; set; }
    }
}
