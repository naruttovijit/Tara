using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class User
    {
        public int Id { get; set; }
        public int? ContactId { get; set; }
        public string MemberNo { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string NameLastName { get; set; }
        public bool? FgForceChangePw { get; set; }
        public bool? FgPwNeverExpire { get; set; }
        public DateTime? PwExpireDate { get; set; }
        public string Remark { get; set; }
        public int? RoleId { get; set; }
        public string Visible { get; set; }
    }
}
