using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelM4s
{
    public partial class MasterDistrict
    {
        public MasterDistrict()
        {
            MasterTambons = new HashSet<MasterTambon>();
        }

        public int Id { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public int? ProvinceId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual MasterProvince Province { get; set; }
        public virtual ICollection<MasterTambon> MasterTambons { get; set; }
    }
}
