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
    // Promotion
    internal class PromotionConfiguration : EntityTypeConfiguration<Promotion>
    {
        public PromotionConfiguration()
            : this("p4")
        {
        }
 
        public PromotionConfiguration(string schema)
        {
            ToTable(schema + ".Promotion");
            HasKey(x => new { x.Dpno, x.Itstcode, x.Itpromna, x.Itpromno, x.Itsupcd, x.Itemcode, x.Itsubcd, x.Itunitcd });

            Property(x => x.Dpno).HasColumnName("DPNO").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itstcode).HasColumnName("ITSTCODE").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itpromna).HasColumnName("ITPROMNA").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itpromno).HasColumnName("ITPROMNO").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itpromme).HasColumnName("ITPROMME").IsOptional().HasColumnType("nvarchar").HasMaxLength(2);
            Property(x => x.Itpromty).HasColumnName("ITPROMTY").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itqf47Rew).HasColumnName("ITQF/REW").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itpsdate).HasColumnName("ITPSDATE").IsOptional().HasColumnType("date");
            Property(x => x.Itpedate).HasColumnName("ITPEDATE").IsOptional().HasColumnType("date");
            Property(x => x.Itpstime).HasColumnName("ITPSTIME").IsOptional().HasColumnType("nvarchar").HasMaxLength(4);
            Property(x => x.Itpetime).HasColumnName("ITPETIME").IsOptional().HasColumnType("nvarchar").HasMaxLength(4);
            Property(x => x.Itsupcd).HasColumnName("ITSUPCD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itemcode).HasColumnName("ITEMCODE").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itsubcd).HasColumnName("ITSUBCD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itunitcd).HasColumnName("ITUNITCD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itqtynpp).HasColumnName("ITQTYNPP").IsOptional().HasColumnType("int");
            Property(x => x.Itsellpr).HasColumnName("ITSELLPR").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itqtypsp).HasColumnName("ITQTYPSP").IsOptional().HasColumnType("int");
            Property(x => x.Itprompr).HasColumnName("ITPROMPR").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Itprombg).HasColumnName("ITPROMBG").IsOptional().HasColumnType("int");
            Property(x => x.Itpromfg).HasColumnName("ITPROMFG").IsOptional().HasColumnType("int");
            Property(x => x.Itupdate).HasColumnName("ITUPDATE").IsOptional().HasColumnType("date");
            Property(x => x.Itdmardte).HasColumnName("ITDMARDTE").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itdmar).HasColumnName("ITDMAR").IsOptional().HasColumnType("date");
            Property(x => x.Itdmardtenx).HasColumnName("ITDMARDTENX").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itdmarnx).HasColumnName("ITDMARNX").IsOptional().HasColumnType("date");
            Property(x => x.LastUpdateOn).HasColumnName("LastUpdateOn").IsOptional().HasColumnType("datetime");
        }
    }

}
