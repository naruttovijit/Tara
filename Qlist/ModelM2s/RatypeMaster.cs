using System;
using System.Collections.Generic;

namespace Qlist.ModelM2s
{
    public partial class RatypeMaster
    {
        public RatypeMaster()
        {
            ProjectRatypeTls = new HashSet<ProjectRatypeTl>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Active { get; set; }
        public DateTime LastUpdated { get; set; }
        public int EditorId { get; set; }

        public virtual ICollection<ProjectRatypeTl> ProjectRatypeTls { get; set; }
    }
}
