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
    // Scope
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.14.3.0")]
    public class Scope
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public int CreatedBy { get; set; } // CreatedBy
        public DateTime CreatedOnUtc { get; set; } // CreatedOnUtc
        public int? ModifiedBy { get; set; } // ModifiedBy
        public DateTime? ModifiedOnUtc { get; set; } // ModifiedOnUtc

        // Reverse navigation
        public virtual ICollection<ClientAllowScope> ClientAllowScopes { get; set; } // Many to many mapping
        public virtual ICollection<MemberSpecificScope> MemberSpecificScopes { get; set; } // Many to many mapping
        public virtual ICollection<RoleInScope> RoleInScopes { get; set; } // Many to many mapping
        
        public Scope()
        {
            ClientAllowScopes = new List<ClientAllowScope>();
            MemberSpecificScopes = new List<MemberSpecificScope>();
            RoleInScopes = new List<RoleInScope>();
        }
    }

}
