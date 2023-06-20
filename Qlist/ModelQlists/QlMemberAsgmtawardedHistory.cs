using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelQlists
{
    public partial class QlMemberAsgmtawardedHistory
    {
        public int Id { get; set; }
        public int MemberAssignmentId { get; set; }
        public DateTime DateAwarded { get; set; }
        public string Active { get; set; }
        public DateTime LastUpdated { get; set; }
        public int EditorId { get; set; }

        public virtual QlProjectSubMemberAsgmt MemberAssignment { get; set; }
    }
}
