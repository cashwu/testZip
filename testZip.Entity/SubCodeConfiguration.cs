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
    // SubCode
    internal class SubCodeConfiguration : EntityTypeConfiguration<SubCode>
    {
        public SubCodeConfiguration()
            : this("p4")
        {
        }
 
        public SubCodeConfiguration(string schema)
        {
            ToTable(schema + ".SubCode");
            HasKey(x => new { x.Dpno, x.Itemcode, x.Itsubcd, x.Itstcode });

            Property(x => x.Dpno).HasColumnName("DPNO").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itemcode).HasColumnName("ITEMCODE").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itsubcd).HasColumnName("ITSUBCD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itchinm).HasColumnName("ITCHINM").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.Itengnm).HasColumnName("ITENGNM").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.Itupddte).HasColumnName("ITUPDDTE").IsOptional().HasColumnType("date");
            Property(x => x.Itstitm).HasColumnName("ITSTITM").IsOptional().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.Itstitmr).HasColumnName("ITSTITMR").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itstcode).HasColumnName("ITSTCODE").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itactsta).HasColumnName("ITACTSTA").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itsprdchr).HasColumnName("ITSPRDCHR").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Itssubid).HasColumnName("ITSSUBID").IsOptional().HasColumnType("int");
            Property(x => x.LastUpdateOn).HasColumnName("LastUpdateOn").IsOptional().HasColumnType("datetime");
        }
    }

}
