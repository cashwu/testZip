using System.IO;

namespace testZip.Service
{
    public class BlobService : IBlobService
    {
        public bool SaveToBlob(string path, string filename, Stream stream)
        {
            return true;
        }
    }
}