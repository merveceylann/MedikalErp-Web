﻿using System.ComponentModel.DataAnnotations;

namespace SlnErp102.Api.DTOs.Info
{
    public class DepartmentDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
