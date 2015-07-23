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
    // PurchasePrice
    public class PurchasePrice
    {
        public string Dpno { get; set; } // DPNO (Primary key)
        public string Itemcode { get; set; } // ITEMCODE (Primary key)
        public string Itsupcd { get; set; } // ITSUPCD (Primary key)
        public string Itsupm { get; set; } // ITSUPM
        public DateTime? Itupddte { get; set; } // ITUPDDTE
        public decimal? Itnpurp { get; set; } // ITNPURP
        public DateTime? Itnefdte { get; set; } // ITNEFDTE
        public int? Itbgood { get; set; } // ITBGOOD
        public int? Itfgood { get; set; } // ITFGOOD
        public decimal? Itddisc { get; set; } // ITDDISC
        public DateTime? Itdiscdte { get; set; } // ITDISCDTE
        public decimal? Itdsur { get; set; } // ITDSUR
        public DateTime? Itsurdte { get; set; } // ITSURDTE
        public string Itdctyp { get; set; } // ITDCTYP
        public int? Itpklay { get; set; } // ITPKLAY
        public int? Itlaypal { get; set; } // ITLAYPAL
        public string Itordby { get; set; } // ITORDBY
        public string Itstsup { get; set; } // ITSTSUP
        public string Itstsupr { get; set; } // ITSTSUPR
        public string Itstcode { get; set; } // ITSTCODE (Primary key)
        public string Itsubcd { get; set; } // ITSUBCD (Primary key)
        public decimal? Itdmardte { get; set; } // ITDMARDTE
        public DateTime? Itdmar { get; set; } // ITDMAR
        public decimal? Itnpurpnx { get; set; } // ITNPURPNX
        public DateTime? Itnefdtenx { get; set; } // ITNEFDTENX
        public int? Itbgoodnx { get; set; } // ITBGOODNX
        public int? Itfgoodnx { get; set; } // ITFGOODNX
        public decimal? Itdmardtenx { get; set; } // ITDMARDTENX
        public DateTime? Itdmarnx { get; set; } // ITDMARNX
        public decimal? Itddiscnx { get; set; } // ITDDISCNX
        public DateTime? Itdiscdtenx { get; set; } // ITDISCDTENX
        public decimal? Itdsurnx { get; set; } // ITDSURNX
        public DateTime? Itsurdtenx { get; set; } // ITSURDTENX
        public int? Itppack { get; set; } // ITPPACK
        public string Apmc { get; set; } // APMC
        public decimal? ApmcRate { get; set; } // APMC_RATE
        public int? Itppkbox { get; set; } // ITPPKBOX
        public DateTime? LastUpdateOn { get; set; } // LastUpdateOn
    }

}
