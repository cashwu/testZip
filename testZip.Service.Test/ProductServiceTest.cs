using FluentAssertions;
using NSubstitute;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using testZip.Entity;
using testZip.Service.Test.Extention;
using Xunit;

namespace testZip.Service.Test
{
    public class ProductServiceTest
    {
        [Fact]
        public void 取得ProductByImageCodeTest()
        {
            // arrange
            var products = this.GetProduct().AsQueryable();
            var productPictures = this.GetProductPicture().AsQueryable();
            var mockProduct = products.ElementAt(0);

            var mockProductDbSet = Substitute.For<IDbSet<Product>>().Initialize(products);
            var mockProductPictureDbSet = Substitute.For<IDbSet<ProductPicture>>().Initialize(productPictures);
            var mockDbContext = Substitute.For<ICMSDbContext>();

            mockDbContext.Products = mockProductDbSet;
            mockDbContext.ProductPictures = mockProductPictureDbSet;

            var productService = new ProductService(mockDbContext);

            // act
            var result = productService.GetProductByItemCode(mockProduct.ItemCode);

            // assert
            result.Should().NotBeNull();
            result.Id.Should().Be(1);
            result.ItemCode.Should().Be("1000000100101");
            result.ProductPictures.Count.Should().Be(1);
            result.ProductPictures.ElementAt(0).Id.Should().Be(1);
        }

        [Fact]
        public void 儲存一張主要的產品圖片而且原本沒有圖片Test()
        {
            // arrange

            var mockProduct = new Product
            {
                Id = 1,
                ItemCode = "1000000100101"
            };

            var mockUploadImage = new UploadIamge
            {
                ItemCode = mockProduct.ItemCode,
                PictureType = ProductPictureType.Product,
                BlobPath = "",
                Seq = "01"
            };

            var mockProductPicture = new ProductPicture
            {
                Id = 1,
                ProductId = 1,
                ProductPictureType = 1,
                IsMainPicture = true,
                ImageUrl = "imageUrl"
            };

            var mockProductPictures = new List<ProductPicture>()
            {
                mockProductPicture
            }.AsQueryable();

            var mockProductPictureDbSet = Substitute.For<IDbSet<ProductPicture>>().Initialize(mockProductPictures);
            var mockDbContext = Substitute.For<ICMSDbContext>();

            var productService = new ProductService(mockDbContext);
            mockProductPictureDbSet.Add(mockProductPicture).Returns(mockProductPicture);

            mockDbContext.ProductPictures = mockProductPictureDbSet;

            // act
            productService.SaveProductImageData(mockProduct, mockUploadImage, mockProductPicture.ImageUrl);

            // assert
            mockDbContext.ProductPictures.Should().NotBeNull();

            var productPictureResut = mockDbContext.ProductPictures.ElementAt(0);

            productPictureResut.Should().NotBeNull();
            productPictureResut.Id.Should().Be(mockProductPicture.Id);
            productPictureResut.ImageUrl.Should().Be(mockProductPicture.ImageUrl);
            productPictureResut.IsMainPicture.Should().BeTrue();
            productPictureResut.ProductPictureType.Should().Be(mockProductPicture.ProductPictureType);
        }

        [Fact]
        public void 儲存一張主要的產品圖片而且原本有圖片Test()
        {
            var mockProductPicture = new ProductPicture
            {
                Id = 1,
                ProductId = 1,
                ProductPictureType = 1,
                IsMainPicture = true,
                ImageUrl = "imageUrl"
            };

            var mockProductPictures = new List<ProductPicture>()
            {
                mockProductPicture
            }.AsQueryable();

            var mockProduct = new Product
            {
                Id = 1,
                ItemCode = "1000000100101",
                ProductPictures = new List<ProductPicture>(mockProductPictures)
            };

            var mockUploadImage = new UploadIamge
            {
                ItemCode = mockProduct.ItemCode,
                PictureType = ProductPictureType.Product,
                BlobPath = "",
                Seq = "01"
            };

            var fileName = "fileName";


            var mockProductPictureDbSet = Substitute.For<IDbSet<ProductPicture>>().Initialize(mockProductPictures);
            var mockDbContext = Substitute.For<ICMSDbContext>();

            var productService = new ProductService(mockDbContext);
            mockProductPictureDbSet.Add(mockProductPicture).Returns(mockProductPicture);

            mockDbContext.ProductPictures = mockProductPictureDbSet;

            // act
            productService.SaveProductImageData(mockProduct, mockUploadImage, fileName);

            // assert
            mockDbContext.ProductPictures.Should().NotBeNull();

            var productPictureResut = mockDbContext.ProductPictures.ElementAt(0);

            productPictureResut.Should().NotBeNull();
            productPictureResut.Id.Should().Be(mockProductPicture.Id);
            productPictureResut.ImageUrl.Should().Be(fileName);
            productPictureResut.IsMainPicture.Should().BeTrue();
            productPictureResut.ProductPictureType.Should().Be(mockProductPicture.ProductPictureType);
        }

        [Fact]
        public void 儲存一張非主要的產品圖片而且原本沒有圖片Test()
        {
            // arrange

            var mockProduct = new Product
            {
                Id = 1,
                ItemCode = "1000000100101"
            };

            var mockUploadImage = new UploadIamge
            {
                ItemCode = mockProduct.ItemCode,
                PictureType = ProductPictureType.Product,
                BlobPath = "",
                Seq = "02"
            };

            var mockProductPicture = new ProductPicture
            {
                Id = 1,
                ProductId = 1,
                ProductPictureType = 1,
                IsMainPicture = false,
                ImageUrl = "imageUrl"
            };

            var mockProductPictures = new List<ProductPicture>()
            {
                mockProductPicture
            }.AsQueryable();

            var mockProductPictureDbSet = Substitute.For<IDbSet<ProductPicture>>().Initialize(mockProductPictures);
            var mockDbContext = Substitute.For<ICMSDbContext>();

            var productService = new ProductService(mockDbContext);
            mockProductPictureDbSet.Add(mockProductPicture).Returns(mockProductPicture);

            mockDbContext.ProductPictures = mockProductPictureDbSet;

            // act
            productService.SaveProductImageData(mockProduct, mockUploadImage, mockProductPicture.ImageUrl);

            // assert
            mockDbContext.ProductPictures.Should().NotBeNull();

            var productPictureResut = mockDbContext.ProductPictures.ElementAt(0);

            productPictureResut.Should().NotBeNull();
            productPictureResut.Id.Should().Be(mockProductPicture.Id);
            productPictureResut.ImageUrl.Should().Be(mockProductPicture.ImageUrl);
            productPictureResut.IsMainPicture.Should().BeFalse();
            productPictureResut.ProductPictureType.Should().Be(mockProductPicture.ProductPictureType);
        }

        [Fact]
        public void 儲存一張非主要的產品圖片而且原本有圖片Test()
        {
            var mockProductPicture = new ProductPicture
            {
                Id = 1,
                ProductId = 1,
                ProductPictureType = 1,
                IsMainPicture = false,
                ImageUrl = "imageUrl"
            };

            var mockProductPictures = new List<ProductPicture>()
            {
                mockProductPicture
            }.AsQueryable();

            var mockProduct = new Product
            {
                Id = 1,
                ItemCode = "1000000100101",
                ProductPictures = new List<ProductPicture>(mockProductPictures)
            };

            var mockUploadImage = new UploadIamge
            {
                ItemCode = mockProduct.ItemCode,
                PictureType = ProductPictureType.Product,
                BlobPath = "",
                Seq = "02"
            };

            var mockProductPictureDbSet = Substitute.For<IDbSet<ProductPicture>>().Initialize(mockProductPictures);
            var mockDbContext = Substitute.For<ICMSDbContext>();

            var productService = new ProductService(mockDbContext);
            mockProductPictureDbSet.Add(mockProductPicture).Returns(mockProductPicture);

            mockDbContext.ProductPictures = mockProductPictureDbSet;

            // act
            productService.SaveProductImageData(mockProduct, mockUploadImage, mockProductPicture.ImageUrl);

            // assert
            mockDbContext.ProductPictures.Should().NotBeNull();

            var productPictureResut = mockDbContext.ProductPictures.ElementAt(0);

            productPictureResut.Should().NotBeNull();
            productPictureResut.Id.Should().Be(mockProductPicture.Id);
            productPictureResut.ImageUrl.Should().Be(mockProductPicture.ImageUrl);
            productPictureResut.IsMainPicture.Should().BeFalse();
            productPictureResut.ProductPictureType.Should().Be(mockProductPicture.ProductPictureType);
        }

        private List<Product> GetProduct()
        {
            var result = new List<Product>();

            var product = new Product
            {
                Id = 1,
                ItemCode = "1000000100101"
            };

            product.ProductPictures = this.GetProductPicture();

            result.Add(product);

            return result;
        }

        private List<ProductPicture> GetProductPicture()
        {
            var result = new List<ProductPicture>();

            result.Add(new ProductPicture
            {
                Id = 1,
                ProductId = 1,
                ProductPictureType = 1,
                IsMainPicture = true,
                ImageUrl = "imageUrl"
            });

            return result;
        }
    }
}
