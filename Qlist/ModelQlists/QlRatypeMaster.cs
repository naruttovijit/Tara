using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelQlists
{
    public partial class QlRatypeMaster
    {
        public QlRatypeMaster()
        {
            QlProjectRatypeTls = new HashSet<QlProjectRatypeTl>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Active { get; set; }
        public DateTime LastUpdated { get; set; }
        public int EditorId { get; set; }

        public virtual ICollection<QlProjectRatypeTl> QlProjectRatypeTls { get; set; }
    }
}
