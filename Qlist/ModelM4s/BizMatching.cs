using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class BizMatching
    {
        public int Id { get; set; }
        public DateTime TransDate { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string LineId { get; set; }
        public string Product { get; set; }
        public string MemberNo { get; set; }
        public string MemberName { get; set; }
        public string Requirement { get; set; }
    }
}
