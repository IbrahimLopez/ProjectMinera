namespace ProjectMinera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Se_elimino_Required_DeLaRelacionConUsers : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Productos", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Proveedores", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.SolicitudProveedores", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.TiposProveedores", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Productos", new[] { "UserId" });
            DropIndex("dbo.Proveedores", new[] { "UserId" });
            DropIndex("dbo.SolicitudProveedores", new[] { "UserId" });
            DropIndex("dbo.TiposProveedores", new[] { "UserId" });
            AlterColumn("dbo.Productos", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Proveedores", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.SolicitudProveedores", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.TiposProveedores", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Productos", "UserId");
            CreateIndex("dbo.Proveedores", "UserId");
            CreateIndex("dbo.SolicitudProveedores", "UserId");
            CreateIndex("dbo.TiposProveedores", "UserId");
            AddForeignKey("dbo.Productos", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Proveedores", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.SolicitudProveedores", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.TiposProveedores", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TiposProveedores", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.SolicitudProveedores", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Proveedores", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Productos", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.TiposProveedores", new[] { "UserId" });
            DropIndex("dbo.SolicitudProveedores", new[] { "UserId" });
            DropIndex("dbo.Proveedores", new[] { "UserId" });
            DropIndex("dbo.Productos", new[] { "UserId" });
            AlterColumn("dbo.TiposProveedores", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.SolicitudProveedores", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Proveedores", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Productos", "UserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.TiposProveedores", "UserId");
            CreateIndex("dbo.SolicitudProveedores", "UserId");
            CreateIndex("dbo.Proveedores", "UserId");
            CreateIndex("dbo.Productos", "UserId");
            AddForeignKey("dbo.TiposProveedores", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SolicitudProveedores", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Proveedores", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Productos", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
