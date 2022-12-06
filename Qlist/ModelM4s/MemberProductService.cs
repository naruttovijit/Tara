using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelM4s
{
    public partial class MemberProductService
    {
        public MemberProductService()
        {
            BizBatchingTrns = new HashSet<BizBatchingTrn>();
            ProductImages = new HashSet<ProductImage>();
        }

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string MemberNo { get; set; }
        public string ProductName { get; set; }
        public string ProuductDescription { get; set; }
        public int? ProductCategory { get; set; }
        public decimal? Price { get; set; }
        public int? MemberDiscountPercent { get; set; }

        public virtual MemberMaster MemberNoNavigation { get; set; }
        public virtual ICollection<BizBatchingTrn> BizBatchingTrns { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
