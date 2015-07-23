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
    // Barcode
    internal class BarcodeConfiguration : EntityTypeConfiguration<Barcode>
    {
        public BarcodeConfiguration()
            : this("p4")
        {
        }
 
        public BarcodeConfiguration(string schema)
        {
            ToTable(schema + ".Barcode");
            HasKey(x => new { x.Dpno, x.Itemcode, x.Itsubcd, x.Itunitcd, x.Itbarcde, x.Itstcode });

            Property(x => x.Dpno).HasColumnName("DPNO").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itemcode).HasColumnName("ITEMCODE").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itsubcd).HasColumnName("ITSUBCD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itunitcd).HasColumnName("ITUNITCD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itbarcdt).HasColumnName("ITBARCDT").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itbarcdo).HasColumnName("ITBARCDO").IsOptional().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.Itbarcde).HasColumnName("ITBARCDE").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(13).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itbarmj).HasColumnName("ITBARMJ").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itupdate).HasColumnName("ITUPDATE").IsOptional().HasColumnType("date");
            Property(x => x.Itsellpr).HasColumnName("ITSELLPR").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itselprc).HasColumnName("ITSELPRC").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itstcode).HasColumnName("ITSTCODE").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itsminsp).HasColumnName("ITSMINSP").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itsmaxsp).HasColumnName("ITSMAXSP").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itstoler).HasColumnName("ITSTOLER").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itstarget).HasColumnName("ITSTARGET").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itsgross).HasColumnName("ITSGROSS").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itscom).HasColumnName("ITSCOM").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Pnspsdate).HasColumnName("PNSPSDATE").IsOptional().HasColumnType("date");
            Property(x => x.Pnspsuggcsp).HasColumnName("PNSPSUGGCSP").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itbarnewo).HasColumnName("ITBARNEWO").IsOptional().HasColumnType("nvarchar").HasMaxLength(14);
            Property(x => x.Itbrnewe).HasColumnName("ITBRNEWE").IsOptional().HasColumnType("nvarchar").HasMaxLength(14);
            Property(x => x.LastUpdateOn).HasColumnName("LastUpdateOn").IsOptional().HasColumnType("datetime");
        }
    }

}
