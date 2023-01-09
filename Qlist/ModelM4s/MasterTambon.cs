using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class MasterTambon
    {
        public int Id { get; set; }
        public int ZipCode { get; set; }
        public string NameTh { get; set; }
        public string NameEn { get; set; }
        public int? AmphureId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual MasterDistrict Amphure { get; set; }
    }
}
