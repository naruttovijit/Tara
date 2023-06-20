using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelQlists
{
    public partial class QlProjectSubMemberAsgmt
    {
        public QlProjectSubMemberAsgmt()
        {
            QlMemberAsgmtawardedHistories = new HashSet<QlMemberAsgmtawardedHistory>();
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

        public virtual QlProjectSubProjectTl ProjectSubProjectTl { get; set; }
        public virtual ICollection<QlMemberAsgmtawardedHistory> QlMemberAsgmtawardedHistories { get; set; }
    }
}
