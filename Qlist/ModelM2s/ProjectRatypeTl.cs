using System;
using System.Collections.Generic;

namespace Qlist.ModelM2s
{
    public partial class ProjectRatypeTl
    {
        public int Id { get; set; }
        public int ProjectSubProjectTlid { get; set; }
        public int RatypeMasterId { get; set; }
        public string MemberCapability { get; set; }
        public string Active { get; set; }
        public DateTime LastUpdated { get; set; }
        public int EditorId { get; set; }

        public virtual ProjectSubProjectTl ProjectSubProjectTl { get; set; }
        public virtual RatypeMaster RatypeMaster { get; set; }
    }
}
