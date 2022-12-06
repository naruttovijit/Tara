using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelM4s
{
    public partial class MasterCapabilityCatSub
    {
        public MasterCapabilityCatSub()
        {
            MemberCategories = new HashSet<MemberCategory>();
        }

        public int Id { get; set; }
        public string CategoryCatSub { get; set; }
        public string Description { get; set; }
        public int? CategoryCatId { get; set; }
        public int? Status { get; set; }
        public DateTime? LastUpd { get; set; }

        public virtual MasterCapabilityCat CategoryCat { get; set; }
        public virtual ICollection<MemberCategory> MemberCategories { get; set; }
    }
}
