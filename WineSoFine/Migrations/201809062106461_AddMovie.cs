namespace WineSoFine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Wines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        TypeId = c.Byte(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        ProducedDate = c.DateTime(nullable: false),
                        NumberInStock = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Types", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Wines", "TypeId", "dbo.Types");
            DropIndex("dbo.Wines", new[] { "TypeId" });
            DropColumn("dbo.Customers", "Birthdate");
            DropTable("dbo.Types");
            DropTable("dbo.Wines");
        }
    }
}
