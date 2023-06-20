using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelQlists
{
    public partial class QlProjectDocument
    {
        public int Id { get; set; }
        public int ProjectSubProjectTlid { get; set; }
        public string Description { get; set; }
        public string DocumentPath { get; set; }
        public string Active { get; set; }
        public DateTime LastUpdated { get; set; }
        public int EditorId { get; set; }
        public string Path { get; set; }

        public virtual QlProjectSubProjectTl ProjectSubProjectTl { get; set; }
    }
}
