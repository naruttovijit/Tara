using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelM4s
{
    public partial class MasterCapabilityCat
    {
        public MasterCapabilityCat()
        {
            MasterCapabilityCatSubs = new HashSet<MasterCapabilityCatSub>();
        }

        public int Id { get; set; }
        public string CategoryCat { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public DateTime? LastUpd { get; set; }

        public virtual ICollection<MasterCapabilityCatSub> MasterCapabilityCatSubs { get; set; }
    }
}
