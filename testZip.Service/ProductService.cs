using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testZip.Service
{
    public class ProductService : IProductService
    {
        public Product GetProductByItemCode(string itemCode)
        {
            return new Product
            {
                Id = 1,
                ItemCode = "1000000100101"
            };
        }

        public void SaveProductImageData(Product product, UploadIamge uploadIamge, string fileName)
        {
        }
    }
}
