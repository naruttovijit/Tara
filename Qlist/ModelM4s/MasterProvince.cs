using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class MasterProvince
    {
        public MasterProvince()
        {
            MasterDistricts = new HashSet<MasterDistrict>();
        }

        public int Id { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public int? GeographyId { get; set; }
        public int? CountryId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual MasterCountry Country { get; set; }
        public virtual ICollection<MasterDistrict> MasterDistricts { get; set; }
    }
}
