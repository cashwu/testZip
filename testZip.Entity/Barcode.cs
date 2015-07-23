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
    // Barcode
    public class Barcode
    {
        public string Dpno { get; set; } // DPNO (Primary key)
        public string Itemcode { get; set; } // ITEMCODE (Primary key)
        public string Itsubcd { get; set; } // ITSUBCD (Primary key)
        public string Itunitcd { get; set; } // ITUNITCD (Primary key)
        public string Itbarcdt { get; set; } // ITBARCDT
        public string Itbarcdo { get; set; } // ITBARCDO
        public string Itbarcde { get; set; } // ITBARCDE (Primary key)
        public string Itbarmj { get; set; } // ITBARMJ
        public DateTime? Itupdate { get; set; } // ITUPDATE
        public decimal? Itsellpr { get; set; } // ITSELLPR
        public string Itselprc { get; set; } // ITSELPRC
        public string Itstcode { get; set; } // ITSTCODE (Primary key)
        public decimal? Itsminsp { get; set; } // ITSMINSP
        public decimal? Itsmaxsp { get; set; } // ITSMAXSP
        public decimal? Itstoler { get; set; } // ITSTOLER
        public decimal? Itstarget { get; set; } // ITSTARGET
        public decimal? Itsgross { get; set; } // ITSGROSS
        public decimal? Itscom { get; set; } // ITSCOM
        public DateTime? Pnspsdate { get; set; } // PNSPSDATE
        public decimal? Pnspsuggcsp { get; set; } // PNSPSUGGCSP
        public string Itbarnewo { get; set; } // ITBARNEWO
        public string Itbrnewe { get; set; } // ITBRNEWE
        public DateTime? LastUpdateOn { get; set; } // LastUpdateOn
    }

}
