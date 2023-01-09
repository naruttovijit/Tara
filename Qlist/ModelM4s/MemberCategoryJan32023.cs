using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class MemberCategoryJan32023
    {
        public int Id { get; set; }
        public string MemberNo { get; set; }
        public int CategoryId { get; set; }
        public int? CategorySubId { get; set; }

        public virtual MemberMasterJan12023 MemberNoNavigation { get; set; }
    }
}
