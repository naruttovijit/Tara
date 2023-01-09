using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class MemberAddress
    {
        public int Id { get; set; }
        public string MemberNo { get; set; }
        public string AddressNo { get; set; }
        public string Moo { get; set; }
        public string Soi { get; set; }
        public string Road { get; set; }
        public double? TambonId { get; set; }
        public double? PostCode { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
    }
}
