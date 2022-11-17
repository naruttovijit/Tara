using System;
using System.Collections.Generic;

namespace Qlist.ModelM2s
{
    public partial class ProjectSubProjectTl
    {
        public ProjectSubProjectTl()
        {
            ProjectDocuments = new HashSet<ProjectDocument>();
            ProjectRatypeTls = new HashSet<ProjectRatypeTl>();
            ProjectSubMemberAsgmts = new HashSet<ProjectSubMemberAsgmt>();
            ProjectSubProjectTlhistories = new HashSet<ProjectSubProjectTlhistory>();
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

        public virtual ProjectHd ProjectHd { get; set; }
        public virtual ICollection<ProjectDocument> ProjectDocuments { get; set; }
        public virtual ICollection<ProjectRatypeTl> ProjectRatypeTls { get; set; }
        public virtual ICollection<ProjectSubMemberAsgmt> ProjectSubMemberAsgmts { get; set; }
        public virtual ICollection<ProjectSubProjectTlhistory> ProjectSubProjectTlhistories { get; set; }
    }
}
