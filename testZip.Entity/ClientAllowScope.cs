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
    public class ClientAllowScope
    {
        public int ClientId { get; set; } // ClientId (Primary key)
        public int ScopeId { get; set; } // ScopeId (Primary key)
        public bool IsDeleted { get; set; } // IsDeleted
        public int CreatedBy { get; set; } // CreatedBy
        public DateTime CreatedOnUtc { get; set; } // CreatedOnUtc
        public int? DeletedBy { get; set; } // DeletedBy
        public DateTime? DeletedOnUtc { get; set; } // DeletedOnUtc

        // Foreign keys
        public virtual Client Client { get; set; } // FK_ClientAllowScope_Client
        public virtual Scope Scope { get; set; } // FK_ClientAllowScope_Scope
        
        public ClientAllowScope()
        {
            IsDeleted = false;
        }
    }

}
