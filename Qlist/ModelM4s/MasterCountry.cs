using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelM4s
{
    public partial class MasterCountry
    {
        public MasterCountry()
        {
            MasterProvinces = new HashSet<MasterProvince>();
        }

        public int Id { get; set; }
        public string Country { get; set; }

        public virtual ICollection<MasterProvince> MasterProvinces { get; set; }
    }
}
