using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelQlists
{
    public partial class QlProjectSubProjectTlhistory
    {
        public int Id { get; set; }
        public int ProjectSubProjectTlid { get; set; }
        public string Remark { get; set; }
        public DateTime TimeStamp { get; set; }
        public int EditorId { get; set; }

        public virtual QlProjectSubProjectTl ProjectSubProjectTl { get; set; }
    }
}
