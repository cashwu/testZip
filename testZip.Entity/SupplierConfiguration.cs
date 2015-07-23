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
    // Supplier
    internal class SupplierConfiguration : EntityTypeConfiguration<Supplier>
    {
        public SupplierConfiguration()
            : this("p4")
        {
        }
 
        public SupplierConfiguration(string schema)
        {
            ToTable(schema + ".Supplier");
            HasKey(x => new { x.Dpno, x.Suppcode, x.Stcd });

            Property(x => x.Dpno).HasColumnName("DPNO").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(2).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Suppcode).HasColumnName("SUPPCODE").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Suppspec).HasColumnName("SUPPSPEC").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Suprefix).HasColumnName("SUPREFIX").IsOptional().HasColumnType("nvarchar").HasMaxLength(3);
            Property(x => x.Suchinm).HasColumnName("SUCHINM").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Suengnm).HasColumnName("SUENGNM").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Sutaxno).HasColumnName("SUTAXNO").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.Suean).HasColumnName("SUEAN").IsOptional().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.Sutelno).HasColumnName("SUTELNO").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Sufaxno).HasColumnName("SUFAXNO").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Suemail).HasColumnName("SUEMAIL").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Supmttm1).HasColumnName("SUPMTTM1").IsOptional().HasColumnType("int");
            Property(x => x.Supmttm2).HasColumnName("SUPMTTM2").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Surbpct).HasColumnName("SURBPCT").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Sucrbpct).HasColumnName("SUCRBPCT").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Nobuss).HasColumnName("NOBUSS").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Suupddte).HasColumnName("SUUPDDTE").IsOptional().HasColumnType("date");
            Property(x => x.Stcd).HasColumnName("STCD").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Dcsufg).HasColumnName("DCSUFG").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Suordday).HasColumnName("SUORDDAY").IsOptional().HasColumnType("nvarchar").HasMaxLength(7);
            Property(x => x.Suleadtm).HasColumnName("SULEADTM").IsOptional().HasColumnType("int");
            Property(x => x.Suordper).HasColumnName("SUORDPER").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Sudelday).HasColumnName("SUDELDAY").IsOptional().HasColumnType("nvarchar").HasMaxLength(7);
            Property(x => x.Sucuttm).HasColumnName("SUCUTTM").IsOptional().HasColumnType("nvarchar").HasMaxLength(5);
            Property(x => x.Iscpc).HasColumnName("ISCPC").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Sustppmt).HasColumnName("SUSTPPMT").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Stwhy).HasColumnName("STWHY").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Addr1).HasColumnName("ADDR1").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Addr2).HasColumnName("ADDR2").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Addr3).HasColumnName("ADDR3").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Contpers).HasColumnName("CONTPERS").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Rmtsup).HasColumnName("RMTSUP").IsOptional().HasColumnType("nvarchar").HasMaxLength(4);
            Property(x => x.Suptyp).HasColumnName("SUPTYP").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.Busentity).HasColumnName("BUSENTITY").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.Suplgflag).HasColumnName("SUPLGFLAG").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.SupstateCode).HasColumnName("SUPSTATE_CODE").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.SupstateEdesc).HasColumnName("SUPSTATE_EDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.SupstateLdesc).HasColumnName("SUPSTATE_LDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.SupmunicipalCode).HasColumnName("SUPMUNICIPAL_CODE").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.SupmunicipalEdesc).HasColumnName("SUPMUNICIPAL_EDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.SupmunicipalLdesc).HasColumnName("SUPMUNICIPAL_LDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.SupcityCode).HasColumnName("SUPCITY_CODE").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.SupcityEdesc).HasColumnName("SUPCITY_EDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.SupcityLdesc).HasColumnName("SUPCITY_LDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.SupregionCode).HasColumnName("SUPREGION_CODE").IsOptional().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.SupregionEdesc).HasColumnName("SUPREGION_EDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.SupregionLdesc).HasColumnName("SUPREGION_LDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.SupActLocation).HasColumnName("SUP_ACT_LOCATION").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Suzipcd).HasColumnName("SUZIPCD").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Sugln).HasColumnName("SUGLN").IsOptional().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.LastUpdateOn).HasColumnName("LastUpdateOn").IsOptional().HasColumnType("datetime");
        }
    }

}
