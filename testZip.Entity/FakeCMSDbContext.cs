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
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.14.3.0")]
    public class FakeCMSDbContext : ICMSDbContext
    {
        public IDbSet<AuthToken> AuthTokens { get; set; }
        public IDbSet<Barcode> Barcodes { get; set; }
        public IDbSet<Catalogue> Catalogues { get; set; }
        public IDbSet<Client> Clients { get; set; }
        public IDbSet<ClientAllowScope> ClientAllowScopes { get; set; }
        public IDbSet<ItemAttribute> ItemAttributes { get; set; }
        public IDbSet<ItemMaster> ItemMasters { get; set; }
        public IDbSet<Member> Members { get; set; }
        public IDbSet<MemberInRole> MemberInRoles { get; set; }
        public IDbSet<MemberSpecificScope> MemberSpecificScopes { get; set; }
        public IDbSet<Merchandise> Merchandises { get; set; }
        public IDbSet<Product> Products { get; set; }
        public IDbSet<ProductPicture> ProductPictures { get; set; }
        public IDbSet<Promotion> Promotions { get; set; }
        public IDbSet<PurchasePrice> PurchasePrices { get; set; }
        public IDbSet<Restructure> Restructures { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<RoleInScope> RoleInScopes { get; set; }
        public IDbSet<Scope> Scopes { get; set; }
        public IDbSet<SubCode> SubCodes { get; set; }
        public IDbSet<Supplier> Suppliers { get; set; }
        public IDbSet<SupplierAttribute> SupplierAttributes { get; set; }
        public IDbSet<Sysdiagram> Sysdiagrams { get; set; }

        public FakeCMSDbContext()
        {
            AuthTokens = new FakeDbSet<AuthToken>();
            Barcodes = new FakeDbSet<Barcode>();
            Catalogues = new FakeDbSet<Catalogue>();
            Clients = new FakeDbSet<Client>();
            ClientAllowScopes = new FakeDbSet<ClientAllowScope>();
            ItemAttributes = new FakeDbSet<ItemAttribute>();
            ItemMasters = new FakeDbSet<ItemMaster>();
            Members = new FakeDbSet<Member>();
            MemberInRoles = new FakeDbSet<MemberInRole>();
            MemberSpecificScopes = new FakeDbSet<MemberSpecificScope>();
            Merchandises = new FakeDbSet<Merchandise>();
            Products = new FakeDbSet<Product>();
            ProductPictures = new FakeDbSet<ProductPicture>();
            Promotions = new FakeDbSet<Promotion>();
            PurchasePrices = new FakeDbSet<PurchasePrice>();
            Restructures = new FakeDbSet<Restructure>();
            Roles = new FakeDbSet<Role>();
            RoleInScopes = new FakeDbSet<RoleInScope>();
            Scopes = new FakeDbSet<Scope>();
            SubCodes = new FakeDbSet<SubCode>();
            Suppliers = new FakeDbSet<Supplier>();
            SupplierAttributes = new FakeDbSet<SupplierAttribute>();
            Sysdiagrams = new FakeDbSet<Sysdiagram>();
        }

        public int SaveChanges()
        {
            return 0;
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
        
        // Stored Procedures
    }
}
