using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class BookTypeViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [MinLength(3,ErrorMessage = "Kitap türü adı minimum 3 karakter olmalı")]
        public string BookTypeName { get; set; }
    }
}
