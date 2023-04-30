﻿using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
