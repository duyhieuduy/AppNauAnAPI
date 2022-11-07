using System;
using System.Collections.Generic;

namespace AppNauAnAPI.Models
{
    public partial class Mon
    {
        public Mon()
        {
            Congthucnguyenlieus = new HashSet<Congthucnguyenlieu>();
        }

        public string Mamon { get; set; } = null!;
        public string? Tenmon { get; set; }
        public string? Maloai { get; set; }
        public string? Congthuclam { get; set; }

        public virtual Loaimon? MaloaiNavigation { get; set; }
        public virtual ICollection<Congthucnguyenlieu> Congthucnguyenlieus { get; set; }
    }
}
