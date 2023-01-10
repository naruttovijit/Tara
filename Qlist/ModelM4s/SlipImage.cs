using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class SlipImage
    {
        public int Id { get; set; }
        public DateTime? UpLoadDate { get; set; }
        public int? SlipId { get; set; }
        public string MemberNo { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Description { get; set; }
        public string FullImage { get; set; }
    }
}
