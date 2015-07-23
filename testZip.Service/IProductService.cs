using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testZip.Entity;

namespace testZip.Service
{
    public interface IProductService
    {
        Product GetProductByItemCode(string itemCode);

        void SaveProductImageData(Product product, UploadIamge uploadIamge, string fileName);
    }
}
