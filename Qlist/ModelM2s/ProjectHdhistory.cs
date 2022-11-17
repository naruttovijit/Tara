using System;
using System.Collections.Generic;

namespace Qlist.ModelM2s
{
    public partial class ProjectHdhistory
    {
        public int Id { get; set; }
        public int ProjectHdid { get; set; }
        public string Remark { get; set; }
        public DateTime TimeStamp { get; set; }
        public int EditorId { get; set; }

        public virtual ProjectHd ProjectHd { get; set; }
    }
}
