using System.ComponentModel;

namespace testZip.Service
{
    public enum ProductPictureType
    {
        [Description("商品圖片")]
        Product = 1,

        [Description("促銷圖片")]
        Sale = 2
    }
}