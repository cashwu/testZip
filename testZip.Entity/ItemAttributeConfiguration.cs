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
    // ItemAttribute
    internal class ItemAttributeConfiguration : EntityTypeConfiguration<ItemAttribute>
    {
        public ItemAttributeConfiguration()
            : this("p4")
        {
        }
 
        public ItemAttributeConfiguration(string schema)
        {
            ToTable(schema + ".ItemAttribute");
            HasKey(x => new { x.Itmdpcd, x.Itmitmcd, x.Itaclcd, x.Itacd, x.Itasdate });

            Property(x => x.Itmdpcd).HasColumnName("ITMDPCD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itmitmcd).HasColumnName("ITMITMCD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itaclcd).HasColumnName("ITACLCD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(5).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Atcdesc).HasColumnName("ATCDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Atcshort).HasColumnName("ATCSHORT").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Itacd).HasColumnName("ITACD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(5).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Attcd).HasColumnName("ATTCD").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Attshort).HasColumnName("ATTSHORT").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Itaalph).HasColumnName("ITAALPH").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Itanum).HasColumnName("ITANUM").IsOptional().HasColumnType("bigint");
            Property(x => x.Itadate).HasColumnName("ITADATE").IsOptional().HasColumnType("date");
            Property(x => x.Itatime).HasColumnName("ITATIME").IsOptional().HasColumnType("nvarchar").HasMaxLength(5);
            Property(x => x.Itasdate).HasColumnName("ITASDATE").IsRequired().HasColumnType("date").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itaedate).HasColumnName("ITAEDATE").IsOptional().HasColumnType("date");
            Property(x => x.Itaupdate).HasColumnName("ITAUPDATE").IsOptional().HasColumnType("date");
            Property(x => x.LastUpdateOn).HasColumnName("LastUpdateOn").IsOptional().HasColumnType("datetime");
        }
    }

}
