using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class MasterCapabilityCatSub
    {
        public int Id { get; set; }
        public string CategoryCatSub { get; set; }
        public string Description { get; set; }
        public int? CategoryCatId { get; set; }
        public int? Status { get; set; }
        public DateTime? LastUpd { get; set; }

        public virtual MasterCapabilityCat CategoryCat { get; set; }
    }
}
