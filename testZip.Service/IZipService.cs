using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;

namespace testZip.Service
{
    public interface IZipService
    {
        ZipFile Read(Stream stream);

        int EntriesCount(ZipFile zipFile);

        MemoryStream GetEntryMemoryStream(ZipEntry zipEntry);
    }
}
