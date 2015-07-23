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
    // MemberSpecificScope
    internal class MemberSpecificScopeConfiguration : EntityTypeConfiguration<MemberSpecificScope>
    {
        public MemberSpecificScopeConfiguration()
            : this("auth")
        {
        }
 
        public MemberSpecificScopeConfiguration(string schema)
        {
            ToTable(schema + ".MemberSpecificScope");
            HasKey(x => new { x.MemberId, x.ScopeId });

            Property(x => x.MemberId).HasColumnName("MemberId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ScopeId).HasColumnName("ScopeId").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Accessible).HasColumnName("Accessible").IsRequired().HasColumnType("bit");
            Property(x => x.CreatedBy).HasColumnName("CreatedBy").IsRequired().HasColumnType("int");
            Property(x => x.CreatedOnUtc).HasColumnName("CreatedOnUtc").IsRequired().HasColumnType("datetime");

            // Foreign keys
            HasRequired(a => a.Member).WithMany(b => b.MemberSpecificScopes).HasForeignKey(c => c.MemberId); // FK_MemberSpecificScope_Member
            HasRequired(a => a.Scope).WithMany(b => b.MemberSpecificScopes).HasForeignKey(c => c.ScopeId); // FK_MemberSpecificScope_Group
        }
    }

}
