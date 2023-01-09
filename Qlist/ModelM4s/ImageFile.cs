using System;
using System.Collections.Generic;

namespace Qlist.ModelM4s
{
    public partial class ImageFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public int? FileSize { get; set; }
        public string Base64data { get; set; }
    }
}
