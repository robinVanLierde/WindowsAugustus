namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Leerlings",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Voornaam = c.String(),
                        Naam = c.String(),
                        Email = c.String(),
                        Telefoon = c.String(),
                        opleiding = c.String(),
                        campus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Leerlings");
        }
    }
}
