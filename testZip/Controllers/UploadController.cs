using System;
using System.Web;
using System.Web.Mvc;
using testZip.Service;

namespace testZip.Controllers
{
    public class UploadController : Controller
    {
        private readonly IProductService productService;
        private readonly IBlobService blobService;
        private readonly IZipService zipService;

        public UploadController()
        {
            this.productService = new ProductService();
            this.blobService = new BlobService();
            this.zipService = new ZipService();
        }

        public UploadController(
            IProductService productService,
            IBlobService blobService,
            IZipService zipService)
        {
            this.productService = productService;
            this.blobService = blobService;
            this.zipService = zipService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InputProductImagePack(HttpPostedFileBase file)
        {
            try
            {
                if (file == null || file.ContentLength <= 0)
                {
                    return Json(new
                    {
                        errorMessage = "你沒有上傳任何檔案"
                    });
                }

                var zip = this.zipService.Read(file.InputStream);

                if (this.zipService.EntriesCount(zip) > 500)
                {
                    return Json(new
                    {
                        errorMessage = "圖片數量不可超過500張"
                    });
                }

                foreach (var entry in zip.Entries)
                {
                    if (string.IsNullOrEmpty(entry.FileName))
                    {
                        continue;
                    }

                    //檔案名稱應該為 {{13碼ItemCode}}_{{M or P}}_{{01~99}}.jpg
                    UploadIamge uploadIamge;
                    if (!this.TryGetImageName(entry.FileName, out uploadIamge))
                    {
                        continue;
                    }

                    var product = this.productService.GetProductByItemCode(uploadIamge.ItemCode);

                    if (product == null)
                    {
                        continue;
                    }

                    var stream = this.zipService.GetEntryMemoryStream(entry);

                    var isSuccessSaveBlob = this.blobService.SaveToBlob(
                        uploadIamge.BlobPath,
                        entry.FileName,
                        stream);

                    if (isSuccessSaveBlob)
                    {
                        this.productService.SaveProductImageData(product, uploadIamge, entry.FileName);
                    }
                }

                return Json(new
                {
                    fileName = file.FileName,
                    fileSize = file.ContentLength
                });
            }
            catch (Exception)
            {
                return Json(new
                {
                    errorMessage = $"上傳檔案 : {file?.FileName} 失敗。"
                });
            }
        }

        private bool TryGetImageName(string fileName, out UploadIamge uploadIamge)
        {
            uploadIamge = new UploadIamge();
            var imageNames = fileName.Split(new[] { "_" }, StringSplitOptions.RemoveEmptyEntries);

            if (imageNames.Length != 3)
            {
                return false;
            }

            uploadIamge = new UploadIamge
            {
                ItemCode = imageNames[0]
            };

            if (imageNames[1] == "M")
            {
                uploadIamge.PictureType = ProductPictureType.Product;
                uploadIamge.BlobPath = "product-product";
            }
            else
            {
                uploadIamge.PictureType = ProductPictureType.Sale;
                uploadIamge.BlobPath = "product-sale";
            }

            var tempSeq = imageNames[2].Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries);

            uploadIamge.Seq = tempSeq[0];

            return true;
        }
    }
}