﻿namespace P2.TODOList.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Task
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
    }
}