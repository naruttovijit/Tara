using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class ProductImage
    {
        public int Id { get; set; }
        public int ProductServiceId { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }

        public virtual MemberProductService ProductService { get; set; }
    }
}
