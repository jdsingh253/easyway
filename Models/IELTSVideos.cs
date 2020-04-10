using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace customLogin.Models
{
    public class IELTSVideos
    {
        [Required]
        [MaxLength(50, ErrorMessage ="Name cannot exceed 50 characters")]
        public string Name { get; set; }
        public string VideoPath { get; set; }
        public IFormFile Videos { get; set; }
    }
}
