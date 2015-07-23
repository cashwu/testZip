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
    // ItemMaster
    internal class ItemMasterConfiguration : EntityTypeConfiguration<ItemMaster>
    {
        public ItemMasterConfiguration()
            : this("p4")
        {
        }
 
        public ItemMasterConfiguration(string schema)
        {
            ToTable(schema + ".ItemMaster");
            HasKey(x => new { x.Dpno, x.Itemcode, x.Itstcode });

            Property(x => x.Dpno).HasColumnName("DPNO").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itemcode).HasColumnName("ITEMCODE").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itemspec).HasColumnName("ITEMSPEC").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itchinm).HasColumnName("ITCHINM").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Itengnm).HasColumnName("ITENGNM").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Itstunit).HasColumnName("ITSTUNIT").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Itpack).HasColumnName("ITPACK").IsOptional().HasColumnType("int");
            Property(x => x.Itcapa).HasColumnName("ITCAPA").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Itcaput).HasColumnName("ITCAPUT").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Itcapml).HasColumnName("ITCAPML").IsOptional().HasColumnType("int");
            Property(x => x.Itcolno).HasColumnName("ITCOLNO").IsOptional().HasColumnType("nvarchar").HasMaxLength(3);
            Property(x => x.Itsptyp).HasColumnName("ITSPTYP").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itspctrl).HasColumnName("ITSPCTRL").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Ittypsel).HasColumnName("ITTYPSEL").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itseacd).HasColumnName("ITSEACD").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itsensit).HasColumnName("ITSENSIT").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Ittax).HasColumnName("ITTAX").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itsptie).HasColumnName("ITSPTIE").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itupddte).HasColumnName("ITUPDDTE").IsOptional().HasColumnType("date");
            Property(x => x.Itweight).HasColumnName("ITWEIGHT").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itpcwgh).HasColumnName("ITPCWGH").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itcomast).HasColumnName("ITCOMAST").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itstcat).HasColumnName("ITSTCAT").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.Itgrade).HasColumnName("ITGRADE").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.Itcorig).HasColumnName("ITCORIG").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.Italldif).HasColumnName("ITALLDIF").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Italtyp).HasColumnName("ITALTYP").IsOptional().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.Itrbpct).HasColumnName("ITRBPCT").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itmaxse).HasColumnName("ITMAXSE").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itminse).HasColumnName("ITMINSE").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itinpmon).HasColumnName("ITINPMON").IsOptional().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.Itstitm).HasColumnName("ITSTITM").IsOptional().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.Itstitmr).HasColumnName("ITSTITMR").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itaro).HasColumnName("ITARO").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itordday).HasColumnName("ITORDDAY").IsOptional().HasColumnType("nvarchar").HasMaxLength(7);
            Property(x => x.Itordper).HasColumnName("ITORDPER").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Itleadtm).HasColumnName("ITLEADTM").IsOptional().HasColumnType("int");
            Property(x => x.Itdelday).HasColumnName("ITDELDAY").IsOptional().HasColumnType("nvarchar").HasMaxLength(7);
            Property(x => x.Itstcode).HasColumnName("ITSTCODE").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Itsttype).HasColumnName("ITSTTYPE").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itmsupcd).HasColumnName("ITMSUPCD").IsOptional().HasColumnType("nvarchar").HasMaxLength(4);
            Property(x => x.Itdssup).HasColumnName("ITDSSUP").IsOptional().HasColumnType("nvarchar").HasMaxLength(4);
            Property(x => x.Itqtypack).HasColumnName("ITQTYPACK").IsOptional().HasColumnType("int");
            Property(x => x.Itshnm).HasColumnName("ITSHNM").IsOptional().HasColumnType("nvarchar").HasMaxLength(18);
            Property(x => x.Itactst).HasColumnName("ITACTST").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Itmsubtax).HasColumnName("ITMSUBTAX").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.Ittitmname).HasColumnName("ITTITMNAME").IsOptional().HasColumnType("nvarchar").HasMaxLength(18);
            Property(x => x.Itmreturn).HasColumnName("ITMRETURN").IsOptional().HasColumnType("int");
            Property(x => x.Itmwarranty).HasColumnName("ITMWARRANTY").IsOptional().HasColumnType("int");
            Property(x => x.Itmshelfvalue).HasColumnName("ITMSHELFVALUE").IsOptional().HasColumnType("int");
            Property(x => x.Itmshelflife).HasColumnName("ITMSHELFLIFE").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.Itmbrand).HasColumnName("ITMBRAND").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Itmsubbrand).HasColumnName("ITMSUBBRAND").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Itmitmid).HasColumnName("ITMITMID").IsOptional().HasColumnType("int");
            Property(x => x.Itmshelflimit).HasColumnName("ITMSHELFLIMIT").IsOptional().HasColumnType("int");
            Property(x => x.Itmshelflimituom).HasColumnName("ITMSHELFLIMITUOM").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.LastUpdateOn).HasColumnName("LastUpdateOn").IsOptional().HasColumnType("datetime");
        }
    }

}
