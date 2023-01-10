using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class MemberAddressJan22023
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

        public virtual MemberMasterJan12023 MemberNoNavigation { get; set; }
    }
}
