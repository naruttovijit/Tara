using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class BizMatchingTrn
    {
        public int Id { get; set; }
        public DateTime TransDate { get; set; }
        public string MemberNo { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public string Remark { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual MemberProductService Product { get; set; }
    }
}
