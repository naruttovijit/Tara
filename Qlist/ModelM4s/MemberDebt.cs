using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class MemberDebt
    {
        public int Id { get; set; }
        public string MemberNo { get; set; }
        public string DebtDescription { get; set; }
        public double? DebtAmount { get; set; }
        public double? PaidAmount { get; set; }
    }
}
