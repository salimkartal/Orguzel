﻿using System.ComponentModel.DataAnnotations;

namespace Orguzel.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
