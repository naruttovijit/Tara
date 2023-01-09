using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class MemberMasterJan12023
    {
        public MemberMasterJan12023()
        {
            BizMatchingTrns = new HashSet<BizMatchingTrn>();
            CompanyImages = new HashSet<CompanyImage>();
            MemberBizTypes = new HashSet<MemberBizType>();
            MemberContactPeople = new HashSet<MemberContactPerson>();
            MemberProductServices = new HashSet<MemberProductService>();
        }

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string MemberNo { get; set; }
        public DateTime? MemberStartDate { get; set; }
        public int? MemberType { get; set; }
        public int? MemberBusinessType { get; set; }
        public string CompanyNameTh { get; set; }
        public string CompanyNameEn { get; set; }
        public string CompanyRegistrationNo { get; set; }
        public double? RegisterCapital { get; set; }
        public double? ThaiCapitalPercentage { get; set; }
        public string EstablishYear { get; set; }
        public double? FixedAsset { get; set; }
        public int? NumberofEmployee { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Facebook { get; set; }
        public int? IsBoi { get; set; }
        public int? IsCoreMemeber { get; set; }
        public int? IsEnable { get; set; }
        public DateTime? ExpiredDate { get; set; }

        public virtual ICollection<BizMatchingTrn> BizMatchingTrns { get; set; }
        public virtual ICollection<CompanyImage> CompanyImages { get; set; }
        public virtual ICollection<MemberBizType> MemberBizTypes { get; set; }
        public virtual ICollection<MemberContactPerson> MemberContactPeople { get; set; }
        public virtual ICollection<MemberProductService> MemberProductServices { get; set; }
    }
}
