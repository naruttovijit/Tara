using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class Mou
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public string MouName { get; set; }
        public string Partner { get; set; }
        public string MouFile { get; set; }
        public double? FileSize { get; set; }
        public string Base64String { get; set; }
    }
}
