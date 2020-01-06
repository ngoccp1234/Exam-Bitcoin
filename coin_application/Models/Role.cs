using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace coin_application.Models
{
    public class Role : IdentityRole
    {
     
        public DateTime CreatedAt { get; set; }
    }
}