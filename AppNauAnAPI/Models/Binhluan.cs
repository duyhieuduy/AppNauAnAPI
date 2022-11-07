using System;
using System.Collections.Generic;

namespace AppNauAnAPI.Models
{
    public partial class Binhluan
    {
        public string? Tendangnhap { get; set; }
        public string Mamon { get; set; } = null!;
        public string? Noidungbl { get; set; }

        public virtual Mon MamonNavigation { get; set; } = null!;
        public virtual Nguoidung? TendangnhapNavigation { get; set; }
    }
}
