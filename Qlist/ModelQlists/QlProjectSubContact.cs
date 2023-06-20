using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelQlists
{
    public partial class QlProjectSubContact
    {
        public int Id { get; set; }
        public int ProjectSubId { get; set; }
        public int ContactId { get; set; }
        public DateTime TimeStamp { get; set; }
        public int EditorId { get; set; }

        public virtual QlContact Contact { get; set; }
        public virtual QlProjectSubProjectTl ProjectSub { get; set; }
    }
}
