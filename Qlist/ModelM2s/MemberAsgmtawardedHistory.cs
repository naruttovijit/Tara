using System;
using System.Collections.Generic;

namespace Qlist.ModelM2s
{
    public partial class MemberAsgmtawardedHistory
    {
        public int Id { get; set; }
        public int MemberAssignmentId { get; set; }
        public DateTime DateAwarded { get; set; }
        public string Active { get; set; }
        public DateTime LastUpdated { get; set; }
        public int EditorId { get; set; }

        public virtual ProjectSubMemberAsgmt MemberAssignment { get; set; }
    }
}
