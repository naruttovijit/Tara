using System;
using System.Collections.Generic;

namespace Qlist.ModelM2s
{
    public partial class Event
    {
        public int Id { get; set; }
        public int ProjectSubProjectTlid { get; set; }
        public DateTime TargetDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Active { get; set; }
        public DateTime LastUpdated { get; set; }
        public int EditorId { get; set; }
    }
}
