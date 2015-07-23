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
    // Restructure
    internal class RestructureConfiguration : EntityTypeConfiguration<Restructure>
    {
        public RestructureConfiguration()
            : this("p4")
        {
        }
 
        public RestructureConfiguration(string schema)
        {
            ToTable(schema + ".Restructure");
            HasKey(x => new { x.Store, x.Odpno, x.Nitemcde });

            Property(x => x.Store).HasColumnName("STORE").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Odpno).HasColumnName("ODPNO").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Oitemcde).HasColumnName("OITEMCDE").IsOptional().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.Ndpno).HasColumnName("NDPNO").IsOptional().HasColumnType("nvarchar").HasMaxLength(2);
            Property(x => x.Nitemcde).HasColumnName("NITEMCDE").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itrsdate).HasColumnName("ITRSDATE").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Itmove).HasColumnName("ITMOVE").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itmitmid).HasColumnName("ITMITMID").IsOptional().HasColumnType("int");
            Property(x => x.LastUpdateOn).HasColumnName("LastUpdateOn").IsOptional().HasColumnType("datetime");
        }
    }

}
