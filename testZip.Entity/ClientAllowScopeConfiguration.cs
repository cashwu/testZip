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
    // ClientAllowScope
    internal class ClientAllowScopeConfiguration : EntityTypeConfiguration<ClientAllowScope>
    {
        public ClientAllowScopeConfiguration()
            : this("auth")
        {
        }
 
        public ClientAllowScopeConfiguration(string schema)
        {
            ToTable(schema + ".ClientAllowScope");
            HasKey(x => new { x.ClientId, x.ScopeId });

            Property(x => x.ClientId).HasColumnName("ClientId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ScopeId).HasColumnName("ScopeId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.IsDeleted).HasColumnName("IsDeleted").IsRequired().HasColumnType("bit");
            Property(x => x.CreatedBy).HasColumnName("CreatedBy").IsRequired().HasColumnType("int");
            Property(x => x.CreatedOnUtc).HasColumnName("CreatedOnUtc").IsRequired().HasColumnType("datetime");
            Property(x => x.DeletedBy).HasColumnName("DeletedBy").IsOptional().HasColumnType("int");
            Property(x => x.DeletedOnUtc).HasColumnName("DeletedOnUtc").IsOptional().HasColumnType("datetime");

            // Foreign keys
            HasRequired(a => a.Client).WithMany(b => b.ClientAllowScopes).HasForeignKey(c => c.ClientId); // FK_ClientAllowScope_Client
            HasRequired(a => a.Scope).WithMany(b => b.ClientAllowScopes).HasForeignKey(c => c.ScopeId); // FK_ClientAllowScope_Scope
        }
    }

}
