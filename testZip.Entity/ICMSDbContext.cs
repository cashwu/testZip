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
    public interface ICMSDbContext : IDisposable
    {
        IDbSet<AuthToken> AuthTokens { get; set; } // AuthToken
        IDbSet<Barcode> Barcodes { get; set; } // Barcode
        IDbSet<Catalogue> Catalogues { get; set; } // Catalogue
        IDbSet<Client> Clients { get; set; } // Client
        IDbSet<ClientAllowScope> ClientAllowScopes { get; set; } // ClientAllowScope
        IDbSet<ItemAttribute> ItemAttributes { get; set; } // ItemAttribute
        IDbSet<ItemMaster> ItemMasters { get; set; } // ItemMaster
        IDbSet<Member> Members { get; set; } // Member
        IDbSet<MemberInRole> MemberInRoles { get; set; } // MemberInRole
        IDbSet<MemberSpecificScope> MemberSpecificScopes { get; set; } // MemberSpecificScope
        IDbSet<Merchandise> Merchandises { get; set; } // Merchandise
        IDbSet<Product> Products { get; set; } // Products
        IDbSet<ProductPicture> ProductPictures { get; set; } // ProductPictures
        IDbSet<Promotion> Promotions { get; set; } // Promotion
        IDbSet<PurchasePrice> PurchasePrices { get; set; } // PurchasePrice
        IDbSet<Restructure> Restructures { get; set; } // Restructure
        IDbSet<Role> Roles { get; set; } // Role
        IDbSet<RoleInScope> RoleInScopes { get; set; } // RoleInScope
        IDbSet<Scope> Scopes { get; set; } // Scope
        IDbSet<SubCode> SubCodes { get; set; } // SubCode
        IDbSet<Supplier> Suppliers { get; set; } // Supplier
        IDbSet<SupplierAttribute> SupplierAttributes { get; set; } // SupplierAttribute
        IDbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
        // Stored Procedures
    }

}
