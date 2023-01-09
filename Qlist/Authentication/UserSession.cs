namespace Qlist.Authentication
{
    public class UserSession
    {
        public string UserName { get; set; }
        public int? Role { get; set; }
        public int? ContactID { get; set; }
        public string MemberNo { get; set; }
        public int UserID { get; set; }
        public string UserLongName { get; set; }
    }
}
