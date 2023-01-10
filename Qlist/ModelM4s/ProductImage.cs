using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class ProductImage
    {
        public int Id { get; set; }
        public DateTime? UpdDate { get; set; }
        public int? ProductId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Description { get; set; }
        public string FullImage { get; set; }
        public byte[] Image1 { get; set; }
    }
}
