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
    // ItemAttribute
    public class ItemAttribute
    {
        public string Itmdpcd { get; set; } // ITMDPCD (Primary key)
        public string Itmitmcd { get; set; } // ITMITMCD (Primary key)
        public string Itaclcd { get; set; } // ITACLCD (Primary key)
        public string Atcdesc { get; set; } // ATCDESC
        public string Atcshort { get; set; } // ATCSHORT
        public string Itacd { get; set; } // ITACD (Primary key)
        public string Attcd { get; set; } // ATTCD
        public string Attshort { get; set; } // ATTSHORT
        public string Itaalph { get; set; } // ITAALPH
        public long? Itanum { get; set; } // ITANUM
        public DateTime? Itadate { get; set; } // ITADATE
        public string Itatime { get; set; } // ITATIME
        public DateTime Itasdate { get; set; } // ITASDATE (Primary key)
        public DateTime? Itaedate { get; set; } // ITAEDATE
        public DateTime? Itaupdate { get; set; } // ITAUPDATE
        public DateTime? LastUpdateOn { get; set; } // LastUpdateOn
    }

}
