using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelM4s
{
    public partial class MemberContactPerson
    {
        public int Id { get; set; }
        public string MemberNo { get; set; }
        public string Title { get; set; }
        public string FirstNameTh { get; set; }
        public string LastNameTh { get; set; }
        public string FirstNameEn { get; set; }
        public string LastNameEn { get; set; }
        public string Nationality { get; set; }
        public string Position { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string LineId { get; set; }
        public string FaceBook { get; set; }
        public string Linkedin { get; set; }
        public bool? IsOwner { get; set; }
        public double? ShareBaht { get; set; }
        public int? ShaerPercent { get; set; }

        public virtual MemberMaster MemberNoNavigation { get; set; }
    }
}
