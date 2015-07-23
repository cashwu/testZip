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
    // ItemMaster
    public class ItemMaster
    {
        public string Dpno { get; set; } // DPNO (Primary key)
        public string Itemcode { get; set; } // ITEMCODE (Primary key)
        public string Itemspec { get; set; } // ITEMSPEC
        public string Itchinm { get; set; } // ITCHINM
        public string Itengnm { get; set; } // ITENGNM
        public string Itstunit { get; set; } // ITSTUNIT
        public int? Itpack { get; set; } // ITPACK
        public string Itcapa { get; set; } // ITCAPA
        public string Itcaput { get; set; } // ITCAPUT
        public int? Itcapml { get; set; } // ITCAPML
        public string Itcolno { get; set; } // ITCOLNO
        public string Itsptyp { get; set; } // ITSPTYP
        public string Itspctrl { get; set; } // ITSPCTRL
        public string Ittypsel { get; set; } // ITTYPSEL
        public string Itseacd { get; set; } // ITSEACD
        public string Itsensit { get; set; } // ITSENSIT
        public string Ittax { get; set; } // ITTAX
        public string Itsptie { get; set; } // ITSPTIE
        public DateTime? Itupddte { get; set; } // ITUPDDTE
        public string Itweight { get; set; } // ITWEIGHT
        public string Itpcwgh { get; set; } // ITPCWGH
        public string Itcomast { get; set; } // ITCOMAST
        public string Itstcat { get; set; } // ITSTCAT
        public string Itgrade { get; set; } // ITGRADE
        public string Itcorig { get; set; } // ITCORIG
        public string Italldif { get; set; } // ITALLDIF
        public string Italtyp { get; set; } // ITALTYP
        public decimal? Itrbpct { get; set; } // ITRBPCT
        public decimal? Itmaxse { get; set; } // ITMAXSE
        public decimal? Itminse { get; set; } // ITMINSE
        public string Itinpmon { get; set; } // ITINPMON
        public string Itstitm { get; set; } // ITSTITM
        public string Itstitmr { get; set; } // ITSTITMR
        public string Itaro { get; set; } // ITARO
        public string Itordday { get; set; } // ITORDDAY
        public decimal? Itordper { get; set; } // ITORDPER
        public int? Itleadtm { get; set; } // ITLEADTM
        public string Itdelday { get; set; } // ITDELDAY
        public string Itstcode { get; set; } // ITSTCODE (Primary key)
        public string Itsttype { get; set; } // ITSTTYPE
        public string Itmsupcd { get; set; } // ITMSUPCD
        public string Itdssup { get; set; } // ITDSSUP
        public int? Itqtypack { get; set; } // ITQTYPACK
        public string Itshnm { get; set; } // ITSHNM
        public string Itactst { get; set; } // ITACTST
        public string Itmsubtax { get; set; } // ITMSUBTAX
        public string Ittitmname { get; set; } // ITTITMNAME
        public int? Itmreturn { get; set; } // ITMRETURN
        public int? Itmwarranty { get; set; } // ITMWARRANTY
        public int? Itmshelfvalue { get; set; } // ITMSHELFVALUE
        public string Itmshelflife { get; set; } // ITMSHELFLIFE
        public string Itmbrand { get; set; } // ITMBRAND
        public string Itmsubbrand { get; set; } // ITMSUBBRAND
        public int? Itmitmid { get; set; } // ITMITMID
        public int? Itmshelflimit { get; set; } // ITMSHELFLIMIT
        public string Itmshelflimituom { get; set; } // ITMSHELFLIMITUOM
        public DateTime? LastUpdateOn { get; set; } // LastUpdateOn
    }

}
