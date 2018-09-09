namespace ProjectMinera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtributoNuevoEnIdentityModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Eliminado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Eliminado");
        }
    }
}
