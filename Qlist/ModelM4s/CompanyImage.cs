using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelM4s
{
    public partial class CompanyImage
    {
        public int Id { get; set; }
        public string MemberNo { get; set; }
        public byte[] Logoimage { get; set; }

        public virtual MemberMaster MemberNoNavigation { get; set; }
    }
}
