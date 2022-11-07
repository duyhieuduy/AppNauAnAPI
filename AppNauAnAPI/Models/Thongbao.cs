using System;
using System.Collections.Generic;

namespace AppNauAnAPI.Models
{
    public partial class Thongbao
    {
        public string Tendangnhap { get; set; } = null!;
        public string? Noidungtb { get; set; }

        public virtual Nguoidung TendangnhapNavigation { get; set; } = null!;
    }
}
