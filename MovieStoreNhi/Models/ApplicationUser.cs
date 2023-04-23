using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreNhi.Models
{
	public class ApplicationUser : IdentityUser
	{
        [Display(Name = "Họ tên")]
        public string FullName { get; set; }
    }
}

