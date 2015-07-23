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
    // RoleInScope
    internal class RoleInScopeConfiguration : EntityTypeConfiguration<RoleInScope>
    {
        public RoleInScopeConfiguration()
            : this("auth")
        {
        }
 
        public RoleInScopeConfiguration(string schema)
        {
            ToTable(schema + ".RoleInScope");
            HasKey(x => new { x.RoleId, x.ScopeId });

            Property(x => x.RoleId).HasColumnName("RoleId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ScopeId).HasColumnName("ScopeId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IsDeleted).HasColumnName("IsDeleted").IsRequired().HasColumnType("bit");
            Property(x => x.CreatedBy).HasColumnName("CreatedBy").IsRequired().HasColumnType("int");
            Property(x => x.CreatedOnUtc).HasColumnName("CreatedOnUtc").IsRequired().HasColumnType("datetime");
            Property(x => x.DeletedBy).HasColumnName("DeletedBy").IsOptional().HasColumnType("int");
            Property(x => x.DeletedOnUtc).HasColumnName("DeletedOnUtc").IsOptional().HasColumnType("datetime");

            // Foreign keys
            HasRequired(a => a.Role).WithMany(b => b.RoleInScopes).HasForeignKey(c => c.RoleId); // FK_RoleInScope_Role
            HasRequired(a => a.Scope).WithMany(b => b.RoleInScopes).HasForeignKey(c => c.ScopeId); // FK_RoleInScope_Scope
        }
    }

}
