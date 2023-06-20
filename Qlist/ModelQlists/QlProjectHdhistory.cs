using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelQlists
{
    public partial class QlProjectHdhistory
    {
        public int Id { get; set; }
        public int ProjectHdid { get; set; }
        public string Remark { get; set; }
        public DateTime TimeStamp { get; set; }
        public int EditorId { get; set; }

        public virtual QlProjectHd ProjectHd { get; set; }
    }
}
