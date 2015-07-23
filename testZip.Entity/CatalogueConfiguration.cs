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
    // Catalogue
    internal class CatalogueConfiguration : EntityTypeConfiguration<Catalogue>
    {
        public CatalogueConfiguration()
            : this("cms")
        {
        }
 
        public CatalogueConfiguration(string schema)
        {
            ToTable(schema + ".Catalogue");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ParentId).HasColumnName("ParentID").IsOptional().HasColumnType("int");
            Property(x => x.Depth).HasColumnName("Depth").IsRequired().HasColumnType("int");
            Property(x => x.LeftExtent).HasColumnName("LeftExtent").IsRequired().HasColumnType("int");
            Property(x => x.RightExtent).HasColumnName("RightExtent").IsRequired().HasColumnType("int");
            Property(x => x.Deleted).HasColumnName("Deleted").IsRequired().HasColumnType("bit");
            Property(x => x.CreatedBy).HasColumnName("CreatedBy").IsRequired().HasColumnType("int");
            Property(x => x.CreatedOnUtc).HasColumnName("CreatedOnUtc").IsRequired().HasColumnType("datetime");
            Property(x => x.ModifiedBy).HasColumnName("ModifiedBy").IsOptional().HasColumnType("int");
            Property(x => x.ModifiedOnUtc).HasColumnName("ModifiedOnUtc").IsOptional().HasColumnType("datetime");
        }
    }

}
