using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanBackend.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Required]
        public DateTime CreatedTime { get; set; }
        [Required]
        public DateTime ModifiedTime { get; set; }

        public BaseEntity()
        {
            var now = DateTime.Now;
            CreatedTime = now;
            ModifiedTime = now;
        }
    }
}
