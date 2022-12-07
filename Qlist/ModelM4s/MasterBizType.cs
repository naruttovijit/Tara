using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class MasterBizType
    {
        public MasterBizType()
        {
            MemberBizTypes = new HashSet<MemberBizType>();
        }

        public int Id { get; set; }
        public string BusinessType { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MemberBizType> MemberBizTypes { get; set; }
    }
}
