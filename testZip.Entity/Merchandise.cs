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
    // Merchandise
    public class Merchandise
    {
        public string Sfmcode { get; set; } // SFMCODE (Primary key)
        public string Sfmedesc { get; set; } // SFMEDESC
        public string Sfmldesc { get; set; } // SFMLDESC
        public string Fmlcode { get; set; } // FMLCODE
        public string Fmledesc { get; set; } // FMLEDESC
        public string Fmlldesc { get; set; } // FMLLDESC
        public string Gfmcode { get; set; } // GFMCODE
        public string Gfmedesc { get; set; } // GFMEDESC
        public string Gfmldesc { get; set; } // GFMLDESC
        public string Depcode { get; set; } // DEPCODE
        public string Depedesc { get; set; } // DEPEDESC
        public string Depldesc { get; set; } // DEPLDESC
        public string Divcode { get; set; } // DIVCODE
        public string Divedesc { get; set; } // DIVEDESC
        public string Divldesc { get; set; } // DIVLDESC
        public string Divcodetyp { get; set; } // DIVCODETYP
        public string Divdesctyp { get; set; } // DIVDESCTYP
        public DateTime? Msupddte { get; set; } // MSUPDDTE
        public DateTime? LastUpdateOn { get; set; } // LastUpdateOn
    }

}
