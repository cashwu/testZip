using System;
using System.Data.Entity;
using System.Linq;
using testZip.Entity;

namespace testZip.Service
{
    public class ProductService : IProductService
    {
        private readonly ICMSDbContext db;

        public ProductService()
        {
            this.db = new CMSDbContext();
        }

        public ProductService(ICMSDbContext db)
        {
            this.db = db;
        }

        public Product GetProductByItemCode(string itemCode)
        {
            return this.db.Products.Include(a => a.ProductPictures)
                       .FirstOrDefault(a => a.ItemCode == itemCode);
        }

        public void SaveProductImageData(Product product, UploadIamge uploadIamge, string fileName)
        {
            if (product == null)
            {
                return;
            }

            //seq == 1 表示為主圖
            if (uploadIamge.Seq == "01")
            {
                var image = product.ProductPictures.FirstOrDefault(
                    a => a.IsMainPicture == true && a.ProductPictureType == (int)uploadIamge.PictureType);

                if (image != null)
                {
                    image.ImageUrl = fileName;
                    image.ModifiedOn = DateTime.UtcNow;
                    image.ModifiedBy = 1;
                }
                else
                {
                    image = this.GetProductPictureInstance(product.Id, fileName, true, (int)uploadIamge.PictureType);
                    this.db.ProductPictures.Add(image);
                }
            }
            else
            {
                var image = product.ProductPictures.FirstOrDefault(
                    a => a.IsMainPicture == false
                        && a.ImageUrl == fileName
                        && a.ProductPictureType == (int)uploadIamge.PictureType);

                if (image != null)
                {
                    image.ImageUrl = fileName;
                    image.ModifiedOn = DateTime.UtcNow;
                    image.ModifiedBy = 1;
                }
                else
                {
                    image = this.GetProductPictureInstance(product.Id, fileName, false, (int)uploadIamge.PictureType);
                    this.db.ProductPictures.Add(image);
                }
            }

            this.db.SaveChanges();
        }

        private ProductPicture GetProductPictureInstance(int productId, string fileName, bool isMainPicture, int pictureType)
        {
            return new ProductPicture()
            {
                ProductId = productId,
                ImageUrl = fileName,
                IsMainPicture = isMainPicture,
                ProductPictureType = pictureType,
                CreatedOn = DateTime.UtcNow,
                CreatedBy = 1,
                ModifiedOn = DateTime.UtcNow,
                ModifiedBy = 1
            };
        }
    }
}
