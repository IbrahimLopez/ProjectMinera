namespace ProjectMinera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioEnRelacionBaseDeDatos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Proveedores", "Activo", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "Nombre", c => c.String());
            AddColumn("dbo.AspNetUsers", "ApellidoPaterno", c => c.String());
            AddColumn("dbo.AspNetUsers", "ApellidoMaterno", c => c.String());
            DropColumn("dbo.Proveedores", "Estatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Proveedores", "Estatus", c => c.String(nullable: false, maxLength: 1));
            DropColumn("dbo.AspNetUsers", "ApellidoMaterno");
            DropColumn("dbo.AspNetUsers", "ApellidoPaterno");
            DropColumn("dbo.AspNetUsers", "Nombre");
            DropColumn("dbo.Proveedores", "Activo");
        }
    }
}
