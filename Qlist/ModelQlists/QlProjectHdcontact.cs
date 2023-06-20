using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelQlists
{
    public partial class QlProjectHdcontact
    {
        public int Id { get; set; }
        public int ProjectHdid { get; set; }
        public int ContactId { get; set; }
        public DateTime TimeStamp { get; set; }
        public int EditorId { get; set; }

        public virtual QlContact Contact { get; set; }
        public virtual QlProjectHd ProjectHd { get; set; }
    }
}
