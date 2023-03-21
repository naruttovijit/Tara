using System;
using System.Collections.Generic;

namespace Qlist.ModelM2s
{
    public partial class Tickets
    {
        public int No { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime TargetDate { get; set; }
        public string DocumentPath { get; set; }
        public string Active { get; set; }
        public DateTime LastUpdated { get; set; }
        public int EditorId { get; set; }
    }
}
