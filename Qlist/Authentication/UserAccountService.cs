using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using Qlist.Data;
using Qlist.ModelM4s;

namespace Qlist.Authentication
{
    public class UserAccountService
    {
        private List<User> _users;
        private List<User> _usersserver;

        public UserAccountService()
        {
            //GetUser();

            //_users = new List<User>
            //{
            //    new User{ Id = 0, LoginName = "admin", Password = "YWRtaW4=", RoleId = 1, MemberNo = "", NameLastName = "Administrator"}
            //};
        }

        public async Task LoadUser()
        {
            if (_usersserver == null)
            {
                await GetUser();

                _users = new List<User>{new User{ Id = 0, LoginName = "admin", Password = "YWRtaW4=", RoleId = 1, MemberNo = "", NameLastName = "Administrator"}};
            }
        }

        public async Task GetUser()
        {
            ProjectData pj = new ProjectData();
            _usersserver = await pj.GetAllUser();
        }

        public User? GetByUserName(string userName)
        {
            User getuser = null;
            if (_usersserver is not null)
            {
                var data = _usersserver.Where(w => w.LoginName == userName).FirstOrDefault();

                if (data is not null)
                {
                    getuser = data;
                }
                else
                {
                    getuser = _users.FirstOrDefault(x => x.LoginName == userName);
                }
            }
            else
            {
                getuser = _users.FirstOrDefault(x => x.LoginName == userName);
            }
            
            return getuser;
        }
    }
}
