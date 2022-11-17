using System;
using System.Collections.Generic;

namespace Qlist.ModelM2s
{
    public partial class ProjectSubMemberAsgmt
    {
        public ProjectSubMemberAsgmt()
        {
            MemberAsgmtawardedHistories = new HashSet<MemberAsgmtawardedHistory>();
        }

        public int Id { get; set; }
        public int ProjectSubProjectTlid { get; set; }
        public int MemberId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateConfirm { get; set; }
        public string Awarded { get; set; }
        public string Active { get; set; }
        public DateTime LastUpdated { get; set; }
        public int EditorId { get; set; }

        public virtual ProjectSubProjectTl ProjectSubProjectTl { get; set; }
        public virtual ICollection<MemberAsgmtawardedHistory> MemberAsgmtawardedHistories { get; set; }
    }
}
