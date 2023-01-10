using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class CompanyImage
    {
        public int Id { get; set; }
        public string MemberNo { get; set; }
        public byte[] Logoimage { get; set; }

        public virtual MemberMasterJan12023 MemberNoNavigation { get; set; }
    }
}
