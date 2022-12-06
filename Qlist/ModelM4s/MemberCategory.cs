using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelM4s
{
    public partial class MemberCategory
    {
        public int Id { get; set; }
        public string MemberNo { get; set; }
        public int CategorySubId { get; set; }

        public virtual MasterCapabilityCatSub CategorySub { get; set; }
        public virtual MemberMaster MemberNoNavigation { get; set; }
    }
}
