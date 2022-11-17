using System;
using System.Collections.Generic;

namespace Qlist.ModelM2s
{
    public partial class ProjectSubProjectTlhistory
    {
        public int Id { get; set; }
        public int ProjectSubProjectTlid { get; set; }
        public string Remark { get; set; }
        public DateTime TimeStamp { get; set; }
        public int EditorId { get; set; }

        public virtual ProjectSubProjectTl ProjectSubProjectTl { get; set; }
    }
}
