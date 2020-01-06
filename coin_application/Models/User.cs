using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace coin_application.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "Vui lòng nhập tên đầy đủ.")]
        [Display(Name = "Full Name")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Tên chỉ được phép trong khoảng từ 5 - 100 ký tự.")]
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}