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
    // SubCode
    public class SubCode
    {
        public string Dpno { get; set; } // DPNO (Primary key)
        public string Itemcode { get; set; } // ITEMCODE (Primary key)
        public string Itsubcd { get; set; } // ITSUBCD (Primary key)
        public string Itchinm { get; set; } // ITCHINM
        public string Itengnm { get; set; } // ITENGNM
        public DateTime? Itupddte { get; set; } // ITUPDDTE
        public string Itstitm { get; set; } // ITSTITM
        public string Itstitmr { get; set; } // ITSTITMR
        public string Itstcode { get; set; } // ITSTCODE (Primary key)
        public string Itactsta { get; set; } // ITACTSTA
        public string Itsprdchr { get; set; } // ITSPRDCHR
        public int? Itssubid { get; set; } // ITSSUBID
        public DateTime? LastUpdateOn { get; set; } // LastUpdateOn
    }

}
