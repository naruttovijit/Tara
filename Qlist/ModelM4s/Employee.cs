using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Position { get; set; }
        public int? CompanyId { get; set; }
    }
}
