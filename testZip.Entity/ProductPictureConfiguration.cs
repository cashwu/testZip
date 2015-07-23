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
    internal class ProductPictureConfiguration : EntityTypeConfiguration<ProductPicture>
    {
        public ProductPictureConfiguration()
            : this("cms")
        {
        }
 
        public ProductPictureConfiguration(string schema)
        {
            ToTable(schema + ".ProductPictures");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductId").IsRequired().HasColumnType("int");
            Property(x => x.ImageUrl).HasColumnName("ImageUrl").IsOptional().HasColumnType("nvarchar");
            Property(x => x.IsMainPicture).HasColumnName("IsMainPicture").IsRequired().HasColumnType("bit");
            Property(x => x.ProductPictureType).HasColumnName("ProductPictureType").IsRequired().HasColumnType("int");
            Property(x => x.CreatedOn).HasColumnName("CreatedOn").IsRequired().HasColumnType("datetime");
            Property(x => x.CreatedBy).HasColumnName("CreatedBy").IsRequired().HasColumnType("int");
            Property(x => x.ModifiedOn).HasColumnName("ModifiedOn").IsRequired().HasColumnType("datetime");
            Property(x => x.ModifiedBy).HasColumnName("ModifiedBy").IsRequired().HasColumnType("int");

            // Foreign keys
            HasRequired(a => a.Product).WithMany(b => b.ProductPictures).HasForeignKey(c => c.ProductId); // FK_cms.ProductPictures_cms.Products_ProductId
        }
    }

}
