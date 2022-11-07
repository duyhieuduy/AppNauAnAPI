using System;
using System.Collections.Generic;

namespace AppNauAnAPI.Models
{
    public partial class Anhmonan
    {
        public string? Anhmon { get; set; }
        public string Mamon { get; set; } = null!;

        public virtual Mon MamonNavigation { get; set; } = null!;
    }
}
