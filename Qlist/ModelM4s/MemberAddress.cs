using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelM4s
{
    public partial class MemberAddress
    {
        public int Id { get; set; }
        public string MemberNo { get; set; }
        public string AddressNo { get; set; }
        public string Moo { get; set; }
        public string Soi { get; set; }
        public string Road { get; set; }
        public int? TambonId { get; set; }
        public string PostCode { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }

        public virtual MemberMaster MemberNoNavigation { get; set; }
        public virtual MasterTambon Tambon { get; set; }
    }
}
