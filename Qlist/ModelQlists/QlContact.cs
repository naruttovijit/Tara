using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelQlists
{
    public partial class QlContact
    {
        public QlContact()
        {
            QlProjectHdcontacts = new HashSet<QlProjectHdcontact>();
            QlProjectSubContacts = new HashSet<QlProjectSubContact>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public bool IsSi { get; set; }
        public string Remark { get; set; }
        public bool Active { get; set; }
        public DateTime LastUpdated { get; set; }
        public int EditorId { get; set; }

        public virtual QlCustomer Customer { get; set; }
        public virtual ICollection<QlProjectHdcontact> QlProjectHdcontacts { get; set; }
        public virtual ICollection<QlProjectSubContact> QlProjectSubContacts { get; set; }
    }
}
