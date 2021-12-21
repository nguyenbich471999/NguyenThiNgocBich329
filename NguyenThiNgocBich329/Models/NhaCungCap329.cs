using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenThiNgocBich329.Models
{
    public class NhaCungCap329
    {
        [Key]
        [Display(Name = "Mã nhà cung cấp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNhaCungCap { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên nhà cung cấp")]
        public string TenNhaCungCap { get; set; }



    }
}