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
    public class CMSDbContext : DbContext, ICMSDbContext
    {
        public IDbSet<AuthToken> AuthTokens { get; set; } // AuthToken
        public IDbSet<Barcode> Barcodes { get; set; } // Barcode
        public IDbSet<Catalogue> Catalogues { get; set; } // Catalogue
        public IDbSet<Client> Clients { get; set; } // Client
        public IDbSet<ClientAllowScope> ClientAllowScopes { get; set; } // ClientAllowScope
        public IDbSet<ItemAttribute> ItemAttributes { get; set; } // ItemAttribute
        public IDbSet<ItemMaster> ItemMasters { get; set; } // ItemMaster
        public IDbSet<Member> Members { get; set; } // Member
        public IDbSet<MemberInRole> MemberInRoles { get; set; } // MemberInRole
        public IDbSet<MemberSpecificScope> MemberSpecificScopes { get; set; } // MemberSpecificScope
        public IDbSet<Merchandise> Merchandises { get; set; } // Merchandise
        public IDbSet<Product> Products { get; set; } // Products
        public IDbSet<ProductPicture> ProductPictures { get; set; } // ProductPictures
        public IDbSet<Promotion> Promotions { get; set; } // Promotion
        public IDbSet<PurchasePrice> PurchasePrices { get; set; } // PurchasePrice
        public IDbSet<Restructure> Restructures { get; set; } // Restructure
        public IDbSet<Role> Roles { get; set; } // Role
        public IDbSet<RoleInScope> RoleInScopes { get; set; } // RoleInScope
        public IDbSet<Scope> Scopes { get; set; } // Scope
        public IDbSet<SubCode> SubCodes { get; set; } // SubCode
        public IDbSet<Supplier> Suppliers { get; set; } // Supplier
        public IDbSet<SupplierAttribute> SupplierAttributes { get; set; } // SupplierAttribute
        public IDbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        
        static CMSDbContext()
        {
            System.Data.Entity.Database.SetInitializer<CMSDbContext>(null);
        }

        public CMSDbContext()
            : base("Name=CarrefourCMSEntities")
        {
        }

        public CMSDbContext(string connectionString) : base(connectionString)
        {
        }

        public CMSDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AuthTokenConfiguration());
            modelBuilder.Configurations.Add(new BarcodeConfiguration());
            modelBuilder.Configurations.Add(new CatalogueConfiguration());
            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new ClientAllowScopeConfiguration());
            modelBuilder.Configurations.Add(new ItemAttributeConfiguration());
            modelBuilder.Configurations.Add(new ItemMasterConfiguration());
            modelBuilder.Configurations.Add(new MemberConfiguration());
            modelBuilder.Configurations.Add(new MemberInRoleConfiguration());
            modelBuilder.Configurations.Add(new MemberSpecificScopeConfiguration());
            modelBuilder.Configurations.Add(new MerchandiseConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new ProductPictureConfiguration());
            modelBuilder.Configurations.Add(new PromotionConfiguration());
            modelBuilder.Configurations.Add(new PurchasePriceConfiguration());
            modelBuilder.Configurations.Add(new RestructureConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new RoleInScopeConfiguration());
            modelBuilder.Configurations.Add(new ScopeConfiguration());
            modelBuilder.Configurations.Add(new SubCodeConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfiguration());
            modelBuilder.Configurations.Add(new SupplierAttributeConfiguration());
            modelBuilder.Configurations.Add(new SysdiagramConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AuthTokenConfiguration(schema));
            modelBuilder.Configurations.Add(new BarcodeConfiguration(schema));
            modelBuilder.Configurations.Add(new CatalogueConfiguration(schema));
            modelBuilder.Configurations.Add(new ClientConfiguration(schema));
            modelBuilder.Configurations.Add(new ClientAllowScopeConfiguration(schema));
            modelBuilder.Configurations.Add(new ItemAttributeConfiguration(schema));
            modelBuilder.Configurations.Add(new ItemMasterConfiguration(schema));
            modelBuilder.Configurations.Add(new MemberConfiguration(schema));
            modelBuilder.Configurations.Add(new MemberInRoleConfiguration(schema));
            modelBuilder.Configurations.Add(new MemberSpecificScopeConfiguration(schema));
            modelBuilder.Configurations.Add(new MerchandiseConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductPictureConfiguration(schema));
            modelBuilder.Configurations.Add(new PromotionConfiguration(schema));
            modelBuilder.Configurations.Add(new PurchasePriceConfiguration(schema));
            modelBuilder.Configurations.Add(new RestructureConfiguration(schema));
            modelBuilder.Configurations.Add(new RoleConfiguration(schema));
            modelBuilder.Configurations.Add(new RoleInScopeConfiguration(schema));
            modelBuilder.Configurations.Add(new ScopeConfiguration(schema));
            modelBuilder.Configurations.Add(new SubCodeConfiguration(schema));
            modelBuilder.Configurations.Add(new SupplierConfiguration(schema));
            modelBuilder.Configurations.Add(new SupplierAttributeConfiguration(schema));
            modelBuilder.Configurations.Add(new SysdiagramConfiguration(schema));
            return modelBuilder;
        }
        
        // Stored Procedures
    }
}
