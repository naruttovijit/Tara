using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Qlist.ModelM4s
{
    public partial class MasterRole
    {
        public MasterRole()
        {
            //Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }
        public string RoleFunction { get; set; }
        
        //public virtual ICollection<User> Users { get; set; }
    }
}
