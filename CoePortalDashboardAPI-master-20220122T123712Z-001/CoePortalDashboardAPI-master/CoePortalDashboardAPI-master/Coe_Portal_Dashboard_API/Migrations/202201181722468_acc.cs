namespace Coe_Portal_Dashboard_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class acc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accelerators",
                c => new
                    {
                        accId = c.Int(nullable: false, identity: true),
                        accName = c.String(unicode: false),
                        accDescr = c.String(unicode: false),
                        accUrl = c.String(unicode: false),
                        accImg = c.String(unicode: false),
                        accDoc = c.String(unicode: false),
                        accVideo = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.accId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accelerators");
        }
    }
}
