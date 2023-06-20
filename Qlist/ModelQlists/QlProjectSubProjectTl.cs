using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelQlists
{
    public partial class QlProjectSubProjectTl
    {
        public QlProjectSubProjectTl()
        {
            QlProjectDocuments = new HashSet<QlProjectDocument>();
            QlProjectRatypeTls = new HashSet<QlProjectRatypeTl>();
            QlProjectSubContacts = new HashSet<QlProjectSubContact>();
            QlProjectSubMemberAsgmts = new HashSet<QlProjectSubMemberAsgmt>();
            QlProjectSubProjectTlhistories = new HashSet<QlProjectSubProjectTlhistory>();
        }

        public int Id { get; set; }
        public DateTime CreateDated { get; set; }
        public int ProjectHdid { get; set; }
        public string ProjectSubRunNo { get; set; }
        public string ProjectSubName { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }
        public double? Budget { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanFinishDate { get; set; }
        public string ProjectSubStatus { get; set; }
        public string Active { get; set; }

        public virtual QlProjectHd ProjectHd { get; set; }
        public virtual ICollection<QlProjectDocument> QlProjectDocuments { get; set; }
        public virtual ICollection<QlProjectRatypeTl> QlProjectRatypeTls { get; set; }
        public virtual ICollection<QlProjectSubContact> QlProjectSubContacts { get; set; }
        public virtual ICollection<QlProjectSubMemberAsgmt> QlProjectSubMemberAsgmts { get; set; }
        public virtual ICollection<QlProjectSubProjectTlhistory> QlProjectSubProjectTlhistories { get; set; }
    }
}
