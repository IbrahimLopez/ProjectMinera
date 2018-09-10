namespace ProjectMinera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relacion_Usuario_ConTablas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SolicitudProveedores",
                c => new
                    {
                        IdSolicitud = c.Int(nullable: false, identity: true),
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
                        Activo = c.Boolean(nullable: false),
                        FechaSolicitud = c.DateTime(nullable: false),
                        TipoSolicitud = c.String(nullable: false),
                        MotivoSolicitud = c.String(nullable: false, maxLength: 200),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.IdSolicitud)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId);
            
            AddColumn("dbo.Productos", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Proveedores", "FechaCreacion", c => c.DateTime(nullable: false));
            AddColumn("dbo.Proveedores", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.TiposProveedores", "UserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Productos", "UserId");
            CreateIndex("dbo.Proveedores", "UserId");
            CreateIndex("dbo.TiposProveedores", "UserId");
            AddForeignKey("dbo.TiposProveedores", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Proveedores", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: false);
            AddForeignKey("dbo.Productos", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Productos", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Proveedores", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.TiposProveedores", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.SolicitudProveedores", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.TiposProveedores", new[] { "UserId" });
            DropIndex("dbo.SolicitudProveedores", new[] { "UserId" });
            DropIndex("dbo.Proveedores", new[] { "UserId" });
            DropIndex("dbo.Productos", new[] { "UserId" });
            DropColumn("dbo.TiposProveedores", "UserId");
            DropColumn("dbo.Proveedores", "UserId");
            DropColumn("dbo.Proveedores", "FechaCreacion");
            DropColumn("dbo.Productos", "UserId");
            DropTable("dbo.SolicitudProveedores");
        }
    }
}
