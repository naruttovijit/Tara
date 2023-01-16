using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class MemberBizType
    {
        public int Id { get; set; }
        public string MemberNo { get; set; }
        public int MemberBizTypeId { get; set; }

        public virtual MasterBizType MemberBizTypeNavigation { get; set; }
    }
}
