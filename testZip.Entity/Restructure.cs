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
    // Restructure
    public class Restructure
    {
        public string Store { get; set; } // STORE (Primary key)
        public string Odpno { get; set; } // ODPNO (Primary key)
        public string Oitemcde { get; set; } // OITEMCDE
        public string Ndpno { get; set; } // NDPNO
        public string Nitemcde { get; set; } // NITEMCDE (Primary key)
        public string Itrsdate { get; set; } // ITRSDATE
        public string Itmove { get; set; } // ITMOVE
        public int? Itmitmid { get; set; } // ITMITMID
        public DateTime? LastUpdateOn { get; set; } // LastUpdateOn
    }

}
