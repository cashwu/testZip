using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;

namespace testZip.Service
{
    public class ZipService : IZipService
    {
        public ZipFile Read(Stream stream)
        {
            return ZipFile.Read(stream);
        }

        public int EntriesCount(ZipFile zipFile)
        {
            return zipFile.Entries.Count;
        }

        public MemoryStream GetEntryMemoryStream(ZipEntry zipEntry)
        {
            var stream = new MemoryStream();
            zipEntry.Extract(stream);
            stream.Position = 0;

            return stream;
        }
    }
}
