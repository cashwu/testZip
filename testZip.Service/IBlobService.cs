using System.IO;

namespace testZip.Service
{
    public interface IBlobService
    {
        bool SaveToBlob(string path, string filename, Stream stream);
    }
}