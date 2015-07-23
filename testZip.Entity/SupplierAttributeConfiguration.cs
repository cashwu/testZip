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
    // SupplierAttribute
    internal class SupplierAttributeConfiguration : EntityTypeConfiguration<SupplierAttribute>
    {
        public SupplierAttributeConfiguration()
            : this("p4")
        {
        }
 
        public SupplierAttributeConfiguration(string schema)
        {
            ToTable(schema + ".SupplierAttribute");
            HasKey(x => new { x.Supsupcd, x.Suaclcd, x.Suacd, x.Suasdate });

            Property(x => x.Supsupcd).HasColumnName("SUPSUPCD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Suaclcd).HasColumnName("SUACLCD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Atcdesc).HasColumnName("ATCDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Atcshort).HasColumnName("ATCSHORT").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Suacd).HasColumnName("SUACD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Attcd).HasColumnName("ATTCD").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Attshort).HasColumnName("ATTSHORT").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Suaalph).HasColumnName("SUAALPH").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Suanum).HasColumnName("SUANUM").IsOptional().HasColumnType("bigint");
            Property(x => x.Suadate).HasColumnName("SUADATE").IsOptional().HasColumnType("date");
            Property(x => x.Suatime).HasColumnName("SUATIME").IsOptional().HasColumnType("nvarchar").HasMaxLength(5);
            Property(x => x.Suasdate).HasColumnName("SUASDATE").IsRequired().HasColumnType("date").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Suaedate).HasColumnName("SUAEDATE").IsOptional().HasColumnType("date");
            Property(x => x.Suaupdate).HasColumnName("SUAUPDATE").IsOptional().HasColumnType("date");
            Property(x => x.LastUpdateOn).HasColumnName("LastUpdateOn").IsOptional().HasColumnType("datetime");
        }
    }

}
