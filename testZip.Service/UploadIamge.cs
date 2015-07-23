using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testZip.Service
{
    public struct UploadIamge
    {
        public string ItemCode { get; set; }

        public ProductPictureType PictureType { get; set; }

        public string BlobPath { get; set; }

        public string Seq { get; set; }
    }
}
