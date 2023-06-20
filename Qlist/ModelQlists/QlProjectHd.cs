using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelQlists
{
    public partial class QlProjectHd
    {
        public QlProjectHd()
        {
            QlProjectHdcontacts = new HashSet<QlProjectHdcontact>();
            QlProjectHdhistories = new HashSet<QlProjectHdhistory>();
            QlProjectSubProjectTls = new HashSet<QlProjectSubProjectTl>();
        }

        public int Id { get; set; }
        public DateTime CreateDated { get; set; }
        public string ProjectHdrunNo { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }
        public string ProjectHdstatus { get; set; }
        public double? Budget { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanFinishDate { get; set; }
        public string Active { get; set; }
        public int? CustomerId { get; set; }

        public virtual QlCustomer Customer { get; set; }
        public virtual ICollection<QlProjectHdcontact> QlProjectHdcontacts { get; set; }
        public virtual ICollection<QlProjectHdhistory> QlProjectHdhistories { get; set; }
        public virtual ICollection<QlProjectSubProjectTl> QlProjectSubProjectTls { get; set; }
    }
}
