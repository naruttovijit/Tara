using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class MemberProduct
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string MemberNo { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int? ProductCategory { get; set; }
        public decimal? Price { get; set; }
        public int? MemberDiscountPercent { get; set; }
    }
}
