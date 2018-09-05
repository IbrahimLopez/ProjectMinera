namespace ProjectMinera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        IdProducto = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                        TiempoRespuesta = c.Time(nullable: false, precision: 7),
                        CapacidadProd = c.Int(nullable: false),
                        LugarEntrega = c.String(nullable: false),
                        IdProveedor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProducto)
                .ForeignKey("dbo.Proveedores", t => t.IdProveedor, cascadeDelete: true)
                .Index(t => t.IdProveedor);
            
            CreateTable(
                "dbo.Proveedores",
                c => new
                    {
                        IdProveedor = c.Int(nullable: false, identity: true),
                        NombreProveedor = c.String(nullable: false),
                        Direccion = c.String(nullable: false),
                        Ciudad = c.String(nullable: false),
                        Estado = c.String(nullable: false),
                        Telefono = c.String(nullable: false, maxLength: 10),
                        NombreCon = c.String(nullable: false),
                        EmailCon = c.String(nullable: false),
                        TelefonoCon = c.String(nullable: false, maxLength: 10),
                        Extension = c.String(nullable: false),
                        Clasificacion = c.String(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 1),
                        TiposProveedores_IdTipo = c.Int(),
                    })
                .PrimaryKey(t => t.IdProveedor)
                .ForeignKey("dbo.TiposProveedores", t => t.TiposProveedores_IdTipo)
                .Index(t => t.TiposProveedores_IdTipo);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.TiposProveedores",
                c => new
                    {
                        IdTipo = c.Int(nullable: false, identity: true),
                        NombreTipo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdTipo);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Proveedores", "TiposProveedores_IdTipo", "dbo.TiposProveedores");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Productos", "IdProveedor", "dbo.Proveedores");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Proveedores", new[] { "TiposProveedores_IdTipo" });
            DropIndex("dbo.Productos", new[] { "IdProveedor" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.TiposProveedores");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Proveedores");
            DropTable("dbo.Productos");
        }
    }
}
