using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class CompanyProfile
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string MemberNo { get; set; }
        public string FileName1 { get; set; }
        public string Base64String { get; set; }
    }
}
