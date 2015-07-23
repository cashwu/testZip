// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using System.Threading.Tasks;
//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace testZip.Entity
{
    // ProductPictures
    public class ProductPicture
    {
        public int Id { get; set; } // Id (Primary key)
        public int ProductId { get; set; } // ProductId
        public string ImageUrl { get; set; } // ImageUrl
        public bool IsMainPicture { get; set; } // IsMainPicture
        public int ProductPictureType { get; set; } // ProductPictureType
        public DateTime CreatedOn { get; set; } // CreatedOn
        public int CreatedBy { get; set; } // CreatedBy
        public DateTime ModifiedOn { get; set; } // ModifiedOn
        public int ModifiedBy { get; set; } // ModifiedBy

        // Foreign keys
        public virtual Product Product { get; set; } // FK_cms.ProductPictures_cms.Products_ProductId
    }

}
