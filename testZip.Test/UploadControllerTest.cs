using FluentAssertions;
using Ionic.Zip;
using NSubstitute;
using System.IO;
using System.Web;
using System.Web.Mvc;
using testZip.Controllers;
using testZip.Entity;
using testZip.Service;
using Xunit;

namespace testZip.Test
{
    public class UploadControllerTest
    {
        [Fact]
        public void InputProductImagePack_return_你沒有上傳任何檔案Test()
        {
            // arrange

            var mockFile = Substitute.For<HttpPostedFileBase>();
            mockFile.ContentLength.Returns(0);

            var mockProductService = Substitute.For<IProductService>();
            var mockBlobService = Substitute.For<IBlobService>();
            var mockZipService = Substitute.For<IZipService>();

            var uploadController = new UploadController(mockProductService, mockBlobService, mockZipService);

            var expected = new
            {
                errorMessage = "你沒有上傳任何檔案"
            };

            // act

            var result = uploadController.InputProductImagePack(mockFile) as JsonResult;

            // assert

            result.Should().NotBeNull();
            result.Data.ShouldBeEquivalentTo(expected);
        }

        [Fact]
        public void InputProductImagePack_return_圖片數量不可超過500張()
        {
            // arrange
            var mockFile = Substitute.For<HttpPostedFileBase>();
            mockFile.ContentLength.Returns(10);
            mockFile.FileName.Returns("fileName");

            var stream = Substitute.For<Stream>();
            mockFile.InputStream.Returns(stream);

            var mockProductService = Substitute.For<IProductService>();
            var mockBlobService = Substitute.For<IBlobService>();
            var mockZipService = Substitute.For<IZipService>();

            var mockZip = Substitute.For<ZipFile>();
            mockZipService.Read(Arg.Any<Stream>()).Returns(mockZip);
            mockZipService.EntriesCount(Arg.Any<ZipFile>()).Returns(501);

            var uploadController = new UploadController(mockProductService, mockBlobService, mockZipService);

            var expected = new
            {
                errorMessage = "圖片數量不可超過500張"
            };

            // act
            var result = uploadController.InputProductImagePack(mockFile) as JsonResult;

            // assert   
            result.Should().NotBeNull();
            result.Data.ShouldBeEquivalentTo(expected);
        }

        [Fact]
        public void InputProductImagePack_新增成功_return_fileName_fileSize()
        {
            // arrange
            var mockFile = Substitute.For<HttpPostedFileBase>();
            var mockFileName = "fileName";
            var mockContentLength = 10;
            mockFile.ContentLength.Returns(mockContentLength);
            mockFile.FileName.Returns(mockFileName);

            var stream = Substitute.For<Stream>();
            mockFile.InputStream.Returns(stream);

            var mockProductService = Substitute.For<IProductService>();

            var product = new Product
            {
                ItemCode = "123"
            };
            mockProductService.GetProductByItemCode(Arg.Any<string>()).Returns(product);

            var mockBlobService = Substitute.For<IBlobService>();
            mockBlobService.SaveToBlob(Arg.Any<string>(), Arg.Any<string>(), Arg.Any<Stream>()).Returns(true);

            var mockZipService = Substitute.For<IZipService>();

            var mockZip = Substitute.For<ZipFile>();

            mockZip.AddEntry("1000000100101_M_01.jpg", Arg.Any<Stream>());

            mockZipService.Read(Arg.Any<Stream>()).Returns(mockZip);
            mockZipService.EntriesCount(mockZip).Returns(1);

            var mockMemoryStream = Arg.Any<MemoryStream>();
            mockZipService.GetEntryMemoryStream(new ZipEntry()).Returns(mockMemoryStream);

            var uploadController = new UploadController(mockProductService, mockBlobService, mockZipService);

            var expected = new
            {
                fileName = mockFileName,
                fileSize = mockContentLength
            };

            // act
            var result = uploadController.InputProductImagePack(mockFile) as JsonResult;

            // assert   
            result.Should().NotBeNull();
            result.Data.ShouldBeEquivalentTo(expected);
        }

        [Fact]
        public void InputProductImagePack_throw_exception()
        {
            // arrange

            var mockFile = Substitute.For<HttpPostedFileBase>();
            mockFile.ContentLength.Returns(1);
            mockFile.FileName.Returns("fileName");

            var mockProductService = Substitute.For<IProductService>();
            var mockBlobService = Substitute.For<IBlobService>();
            var mockZipService = Substitute.For<IZipService>();

            var uploadController = new UploadController(mockProductService, mockBlobService, mockZipService);

            var expected = new
            {
                errorMessage = $"上傳檔案 : fileName 失敗。"
            };

            // act
            var result = uploadController.InputProductImagePack(mockFile) as JsonResult;

            // assert   
            result.Should().NotBeNull();
            result.Data.ShouldBeEquivalentTo(expected);
        }
    }
}
