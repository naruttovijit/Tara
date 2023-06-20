using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelQlists
{
    public partial class QlProjectRatypeTl
    {
        public int Id { get; set; }
        public int ProjectSubProjectTlid { get; set; }
        public int RatypeMasterId { get; set; }
        public string MemberCapability { get; set; }
        public string Active { get; set; }
        public DateTime LastUpdated { get; set; }
        public int EditorId { get; set; }

        public virtual QlProjectSubProjectTl ProjectSubProjectTl { get; set; }
        public virtual QlRatypeMaster RatypeMaster { get; set; }
    }
}
