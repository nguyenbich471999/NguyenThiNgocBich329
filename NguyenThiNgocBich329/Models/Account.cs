using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenThiNgocBich329.Models
{
    public class Account
    {
        [Key]
        public string username { get; set; }
        public string password { get; set; }
    }
}
