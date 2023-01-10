using System;
using System.Collections.Generic;

namespace Qlist.ModelM2s
{
    public partial class ProjectHd
    {
        public ProjectHd()
        {
            ProjectHdhistories = new HashSet<ProjectHdhistory>();
            ProjectSubProjectTls = new HashSet<ProjectSubProjectTl>();
        }

        public int Id { get; set; }
        public DateTime CreateDated { get; set; }
        public string ProjectHdrunNo { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }
        public string CustomerInfo { get; set; }
        public string ContactInfo { get; set; }
        public string ProjectHdstatus { get; set; }
        public double? Budget { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanFinishDate { get; set; }
        public string Active { get; set; }

        public virtual ICollection<ProjectHdhistory> ProjectHdhistories { get; set; }
        public virtual ICollection<ProjectSubProjectTl> ProjectSubProjectTls { get; set; }
    }
}
