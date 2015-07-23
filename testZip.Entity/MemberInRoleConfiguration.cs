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
    // MemberInRole
    internal class MemberInRoleConfiguration : EntityTypeConfiguration<MemberInRole>
    {
        public MemberInRoleConfiguration()
            : this("auth")
        {
        }
 
        public MemberInRoleConfiguration(string schema)
        {
            ToTable(schema + ".MemberInRole");
            HasKey(x => new { x.MemberId, x.RoleId });

            Property(x => x.MemberId).HasColumnName("MemberId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.RoleId).HasColumnName("RoleId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IsDelete).HasColumnName("IsDelete").IsRequired().HasColumnType("bit");
            Property(x => x.CreatedBy).HasColumnName("CreatedBy").IsRequired().HasColumnType("int");
            Property(x => x.CreatedOnUtc).HasColumnName("CreatedOnUtc").IsRequired().HasColumnType("datetime");
            Property(x => x.DeletedBy).HasColumnName("DeletedBy").IsOptional().HasColumnType("int");
            Property(x => x.DeletedOnUtc).HasColumnName("DeletedOnUtc").IsOptional().HasColumnType("datetime");

            // Foreign keys
            HasRequired(a => a.Member).WithMany(b => b.MemberInRoles).HasForeignKey(c => c.MemberId); // FK_MemberInRole_Member
            HasRequired(a => a.Role).WithMany(b => b.MemberInRoles).HasForeignKey(c => c.RoleId); // FK_MemberInRole_Role
        }
    }

}
