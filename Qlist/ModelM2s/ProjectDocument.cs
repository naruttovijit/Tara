using System;
using System.Collections.Generic;

namespace Qlist.ModelM2s
{
    public partial class ProjectDocument
    {
        public int Id { get; set; }
        public int ProjectSubProjectTlid { get; set; }
        public string Description { get; set; }
        public string DocumentPath { get; set; }
        public string Active { get; set; }
        public DateTime LastUpdated { get; set; }
        public int EditorId { get; set; }

        public virtual ProjectSubProjectTl ProjectSubProjectTl { get; set; }
    }
}
