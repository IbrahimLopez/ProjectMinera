namespace ProjectMinera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioDeNombre_Atributo_Activo_a_Aprobada : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SolicitudProveedores", "Aprobada", c => c.Boolean(nullable: false));
            DropColumn("dbo.SolicitudProveedores", "Activo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SolicitudProveedores", "Activo", c => c.Boolean(nullable: false));
            DropColumn("dbo.SolicitudProveedores", "Aprobada");
        }
    }
}
