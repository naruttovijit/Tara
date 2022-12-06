using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelM4s
{
    public partial class MasterTambon
    {
        public MasterTambon()
        {
            MemberAddresses = new HashSet<MemberAddress>();
        }

        public int Id { get; set; }
        public int ZipCode { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public int? AmphureId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual MasterDistrict Amphure { get; set; }
        public virtual ICollection<MemberAddress> MemberAddresses { get; set; }
    }
}
