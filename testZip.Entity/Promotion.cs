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
    // Promotion
    public class Promotion
    {
        public string Dpno { get; set; } // DPNO (Primary key)
        public string Itstcode { get; set; } // ITSTCODE (Primary key)
        public string Itpromna { get; set; } // ITPROMNA (Primary key)
        public string Itpromno { get; set; } // ITPROMNO (Primary key)
        public string Itpromme { get; set; } // ITPROMME
        public string Itpromty { get; set; } // ITPROMTY
        public string Itqf47Rew { get; set; } // ITQF/REW
        public DateTime? Itpsdate { get; set; } // ITPSDATE
        public DateTime? Itpedate { get; set; } // ITPEDATE
        public string Itpstime { get; set; } // ITPSTIME
        public string Itpetime { get; set; } // ITPETIME
        public string Itsupcd { get; set; } // ITSUPCD (Primary key)
        public string Itemcode { get; set; } // ITEMCODE (Primary key)
        public string Itsubcd { get; set; } // ITSUBCD (Primary key)
        public string Itunitcd { get; set; } // ITUNITCD (Primary key)
        public int? Itqtynpp { get; set; } // ITQTYNPP
        public decimal? Itsellpr { get; set; } // ITSELLPR
        public int? Itqtypsp { get; set; } // ITQTYPSP
        public decimal? Itprompr { get; set; } // ITPROMPR
        public int? Itprombg { get; set; } // ITPROMBG
        public int? Itpromfg { get; set; } // ITPROMFG
        public DateTime? Itupdate { get; set; } // ITUPDATE
        public decimal? Itdmardte { get; set; } // ITDMARDTE
        public DateTime? Itdmar { get; set; } // ITDMAR
        public decimal? Itdmardtenx { get; set; } // ITDMARDTENX
        public DateTime? Itdmarnx { get; set; } // ITDMARNX
        public DateTime? LastUpdateOn { get; set; } // LastUpdateOn
    }

}
