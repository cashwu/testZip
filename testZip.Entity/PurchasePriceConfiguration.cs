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
    // PurchasePrice
    internal class PurchasePriceConfiguration : EntityTypeConfiguration<PurchasePrice>
    {
        public PurchasePriceConfiguration()
            : this("p4")
        {
        }
 
        public PurchasePriceConfiguration(string schema)
        {
            ToTable(schema + ".PurchasePrice");
            HasKey(x => new { x.Dpno, x.Itemcode, x.Itsupcd, x.Itstcode, x.Itsubcd });

            Property(x => x.Dpno).HasColumnName("DPNO").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itemcode).HasColumnName("ITEMCODE").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itsupcd).HasColumnName("ITSUPCD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itsupm).HasColumnName("ITSUPM").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itupddte).HasColumnName("ITUPDDTE").IsOptional().HasColumnType("date");
            Property(x => x.Itnpurp).HasColumnName("ITNPURP").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Itnefdte).HasColumnName("ITNEFDTE").IsOptional().HasColumnType("date");
            Property(x => x.Itbgood).HasColumnName("ITBGOOD").IsOptional().HasColumnType("int");
            Property(x => x.Itfgood).HasColumnName("ITFGOOD").IsOptional().HasColumnType("int");
            Property(x => x.Itddisc).HasColumnName("ITDDISC").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itdiscdte).HasColumnName("ITDISCDTE").IsOptional().HasColumnType("date");
            Property(x => x.Itdsur).HasColumnName("ITDSUR").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itsurdte).HasColumnName("ITSURDTE").IsOptional().HasColumnType("date");
            Property(x => x.Itdctyp).HasColumnName("ITDCTYP").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itpklay).HasColumnName("ITPKLAY").IsOptional().HasColumnType("int");
            Property(x => x.Itlaypal).HasColumnName("ITLAYPAL").IsOptional().HasColumnType("int");
            Property(x => x.Itordby).HasColumnName("ITORDBY").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itstsup).HasColumnName("ITSTSUP").IsOptional().HasColumnType("nvarchar").HasMaxLength(7);
            Property(x => x.Itstsupr).HasColumnName("ITSTSUPR").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itstcode).HasColumnName("ITSTCODE").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itsubcd).HasColumnName("ITSUBCD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itdmardte).HasColumnName("ITDMARDTE").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itdmar).HasColumnName("ITDMAR").IsOptional().HasColumnType("date");
            Property(x => x.Itnpurpnx).HasColumnName("ITNPURPNX").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Itnefdtenx).HasColumnName("ITNEFDTENX").IsOptional().HasColumnType("date");
            Property(x => x.Itbgoodnx).HasColumnName("ITBGOODNX").IsOptional().HasColumnType("int");
            Property(x => x.Itfgoodnx).HasColumnName("ITFGOODNX").IsOptional().HasColumnType("int");
            Property(x => x.Itdmardtenx).HasColumnName("ITDMARDTENX").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itdmarnx).HasColumnName("ITDMARNX").IsOptional().HasColumnType("date");
            Property(x => x.Itddiscnx).HasColumnName("ITDDISCNX").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itdiscdtenx).HasColumnName("ITDISCDTENX").IsOptional().HasColumnType("date");
            Property(x => x.Itdsurnx).HasColumnName("ITDSURNX").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itsurdtenx).HasColumnName("ITSURDTENX").IsOptional().HasColumnType("date");
            Property(x => x.Itppack).HasColumnName("ITPPACK").IsOptional().HasColumnType("int");
            Property(x => x.Apmc).HasColumnName("APMC").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.ApmcRate).HasColumnName("APMC_RATE").IsOptional().HasColumnType("decimal").HasPrecision(18,4);
            Property(x => x.Itppkbox).HasColumnName("ITPPKBOX").IsOptional().HasColumnType("int");
            Property(x => x.LastUpdateOn).HasColumnName("LastUpdateOn").IsOptional().HasColumnType("datetime");
        }
    }

}
