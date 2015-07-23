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
    // Supplier
    public class Supplier
    {
        public string Dpno { get; set; } // DPNO (Primary key)
        public string Suppcode { get; set; } // SUPPCODE (Primary key)
        public string Suppspec { get; set; } // SUPPSPEC
        public string Suprefix { get; set; } // SUPREFIX
        public string Suchinm { get; set; } // SUCHINM
        public string Suengnm { get; set; } // SUENGNM
        public string Sutaxno { get; set; } // SUTAXNO
        public string Suean { get; set; } // SUEAN
        public string Sutelno { get; set; } // SUTELNO
        public string Sufaxno { get; set; } // SUFAXNO
        public string Suemail { get; set; } // SUEMAIL
        public int? Supmttm1 { get; set; } // SUPMTTM1
        public string Supmttm2 { get; set; } // SUPMTTM2
        public decimal? Surbpct { get; set; } // SURBPCT
        public decimal? Sucrbpct { get; set; } // SUCRBPCT
        public string Nobuss { get; set; } // NOBUSS
        public DateTime? Suupddte { get; set; } // SUUPDDTE
        public string Stcd { get; set; } // STCD (Primary key)
        public string Dcsufg { get; set; } // DCSUFG
        public string Suordday { get; set; } // SUORDDAY
        public int? Suleadtm { get; set; } // SULEADTM
        public decimal? Suordper { get; set; } // SUORDPER
        public string Sudelday { get; set; } // SUDELDAY
        public string Sucuttm { get; set; } // SUCUTTM
        public string Iscpc { get; set; } // ISCPC
        public string Sustppmt { get; set; } // SUSTPPMT
        public string Stwhy { get; set; } // STWHY
        public string Addr1 { get; set; } // ADDR1
        public string Addr2 { get; set; } // ADDR2
        public string Addr3 { get; set; } // ADDR3
        public string Contpers { get; set; } // CONTPERS
        public string Rmtsup { get; set; } // RMTSUP
        public string Suptyp { get; set; } // SUPTYP
        public string Busentity { get; set; } // BUSENTITY
        public string Suplgflag { get; set; } // SUPLGFLAG
        public string SupstateCode { get; set; } // SUPSTATE_CODE
        public string SupstateEdesc { get; set; } // SUPSTATE_EDESC
        public string SupstateLdesc { get; set; } // SUPSTATE_LDESC
        public string SupmunicipalCode { get; set; } // SUPMUNICIPAL_CODE
        public string SupmunicipalEdesc { get; set; } // SUPMUNICIPAL_EDESC
        public string SupmunicipalLdesc { get; set; } // SUPMUNICIPAL_LDESC
        public string SupcityCode { get; set; } // SUPCITY_CODE
        public string SupcityEdesc { get; set; } // SUPCITY_EDESC
        public string SupcityLdesc { get; set; } // SUPCITY_LDESC
        public string SupregionCode { get; set; } // SUPREGION_CODE
        public string SupregionEdesc { get; set; } // SUPREGION_EDESC
        public string SupregionLdesc { get; set; } // SUPREGION_LDESC
        public string SupActLocation { get; set; } // SUP_ACT_LOCATION
        public string Suzipcd { get; set; } // SUZIPCD
        public string Sugln { get; set; } // SUGLN
        public DateTime? LastUpdateOn { get; set; } // LastUpdateOn
    }

}
