using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class Customer
    {
        public Customer()
        {
            BizBatchingTrns = new HashSet<BizBatchingTrn>();
        }

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string MemberNo { get; set; }
        public string CompanyName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string LineId { get; set; }

        public virtual ICollection<BizBatchingTrn> BizBatchingTrns { get; set; }
    }
}
