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
    // SupplierAttribute
    public class SupplierAttribute
    {
        public string Supsupcd { get; set; } // SUPSUPCD (Primary key)
        public string Suaclcd { get; set; } // SUACLCD (Primary key)
        public string Atcdesc { get; set; } // ATCDESC
        public string Atcshort { get; set; } // ATCSHORT
        public string Suacd { get; set; } // SUACD (Primary key)
        public string Attcd { get; set; } // ATTCD
        public string Attshort { get; set; } // ATTSHORT
        public string Suaalph { get; set; } // SUAALPH
        public long? Suanum { get; set; } // SUANUM
        public DateTime? Suadate { get; set; } // SUADATE
        public string Suatime { get; set; } // SUATIME
        public DateTime Suasdate { get; set; } // SUASDATE (Primary key)
        public DateTime? Suaedate { get; set; } // SUAEDATE
        public DateTime? Suaupdate { get; set; } // SUAUPDATE
        public DateTime? LastUpdateOn { get; set; } // LastUpdateOn
    }

}
