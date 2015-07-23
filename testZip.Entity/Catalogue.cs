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
    // Catalogue
    public class Catalogue
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public int? ParentId { get; set; } // ParentID
        public int Depth { get; set; } // Depth
        public int LeftExtent { get; set; } // LeftExtent
        public int RightExtent { get; set; } // RightExtent
        public bool Deleted { get; set; } // Deleted
        public int CreatedBy { get; set; } // CreatedBy
        public DateTime CreatedOnUtc { get; set; } // CreatedOnUtc
        public int? ModifiedBy { get; set; } // ModifiedBy
        public DateTime? ModifiedOnUtc { get; set; } // ModifiedOnUtc
        
        public Catalogue()
        {
            Depth = 0;
            Deleted = false;
        }
    }

}
