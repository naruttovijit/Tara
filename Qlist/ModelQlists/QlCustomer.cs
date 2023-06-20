using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelQlists
{
    public partial class QlCustomer
    {
        public QlCustomer()
        {
            QlContacts = new HashSet<QlContact>();
            QlProjectHds = new HashSet<QlProjectHd>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Remark { get; set; }
        public bool Active { get; set; }
        public DateTime LastUpdated { get; set; }
        public int EditorId { get; set; }

        public virtual ICollection<QlContact> QlContacts { get; set; }
        public virtual ICollection<QlProjectHd> QlProjectHds { get; set; }
    }
}
