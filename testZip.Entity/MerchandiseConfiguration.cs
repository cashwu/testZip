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
    // Merchandise
    internal class MerchandiseConfiguration : EntityTypeConfiguration<Merchandise>
    {
        public MerchandiseConfiguration()
            : this("p4")
        {
        }
 
        public MerchandiseConfiguration(string schema)
        {
            ToTable(schema + ".Merchandise");
            HasKey(x => x.Sfmcode);

            Property(x => x.Sfmcode).HasColumnName("SFMCODE").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(5).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Sfmedesc).HasColumnName("SFMEDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Sfmldesc).HasColumnName("SFMLDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Fmlcode).HasColumnName("FMLCODE").IsOptional().HasColumnType("nvarchar").HasMaxLength(4);
            Property(x => x.Fmledesc).HasColumnName("FMLEDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Fmlldesc).HasColumnName("FMLLDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Gfmcode).HasColumnName("GFMCODE").IsOptional().HasColumnType("nvarchar").HasMaxLength(9);
            Property(x => x.Gfmedesc).HasColumnName("GFMEDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Gfmldesc).HasColumnName("GFMLDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Depcode).HasColumnName("DEPCODE").IsOptional().HasColumnType("nvarchar").HasMaxLength(2);
            Property(x => x.Depedesc).HasColumnName("DEPEDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Depldesc).HasColumnName("DEPLDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Divcode).HasColumnName("DIVCODE").IsOptional().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.Divedesc).HasColumnName("DIVEDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Divldesc).HasColumnName("DIVLDESC").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Divcodetyp).HasColumnName("DIVCODETYP").IsOptional().HasColumnType("nvarchar").HasMaxLength(4);
            Property(x => x.Divdesctyp).HasColumnName("DIVDESCTYP").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Msupddte).HasColumnName("MSUPDDTE").IsOptional().HasColumnType("date");
            Property(x => x.LastUpdateOn).HasColumnName("LastUpdateOn").IsOptional().HasColumnType("datetime");
        }
    }

}
