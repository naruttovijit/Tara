using System;
using System.Collections.Generic;

namespace Taraweb.Middleware.ModelM4s
{
    public partial class MemberMaster
    {
        public MemberMaster()
        {
            BizBatchingTrns = new HashSet<BizBatchingTrn>();
            CompanyImages = new HashSet<CompanyImage>();
            MemberAddresses = new HashSet<MemberAddress>();
            MemberBizTypes = new HashSet<MemberBizType>();
            MemberCategories = new HashSet<MemberCategory>();
            MemberContactPeople = new HashSet<MemberContactPerson>();
            MemberPaymentTrns = new HashSet<MemberPaymentTrn>();
            MemberProductServices = new HashSet<MemberProductService>();
        }

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string MemberNo { get; set; }
        public DateTime? MemberStartDate { get; set; }
        public int? MemberType { get; set; }
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
        public bool? IsBoi { get; set; }
        public bool? IsCoreMemeber { get; set; }
        public bool? IsEnable { get; set; }
        public DateTime? ExpiredDate { get; set; }

        public virtual ICollection<BizBatchingTrn> BizBatchingTrns { get; set; }
        public virtual ICollection<CompanyImage> CompanyImages { get; set; }
        public virtual ICollection<MemberAddress> MemberAddresses { get; set; }
        public virtual ICollection<MemberBizType> MemberBizTypes { get; set; }
        public virtual ICollection<MemberCategory> MemberCategories { get; set; }
        public virtual ICollection<MemberContactPerson> MemberContactPeople { get; set; }
        public virtual ICollection<MemberPaymentTrn> MemberPaymentTrns { get; set; }
        public virtual ICollection<MemberProductService> MemberProductServices { get; set; }
    }
}
