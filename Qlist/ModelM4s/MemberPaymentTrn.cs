using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class MemberPaymentTrn
    {
        public int Id { get; set; }
        public DateTime TransDate { get; set; }
        public string MemberNo { get; set; }
        public string BankName { get; set; }
        public string PaymentReference { get; set; }
        public decimal? PaymentTotal { get; set; }
    }
}
