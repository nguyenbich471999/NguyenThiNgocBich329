using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenThiNgocBich329.Models
{
    public class NTNBSanPhan329
    {
      
            [Key]
            [Display(Name = "Mã Sản Phẩm")]
            public int MaSanPham { get; set; }
            [Display(Name = "Tên sản phẩm")]
            public string TenSanPham { get; set; }
            [Display(Name = "Mã Nhà cung cấp")]
            public int MaNhaCungCap { get; set; }
          
        public NhaCungCap329 nhaCungCap329 { get; set; }

        }
    }