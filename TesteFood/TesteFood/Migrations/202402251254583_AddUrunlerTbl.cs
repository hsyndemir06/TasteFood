namespace TesteFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrunlerTbl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        UrdunID = c.Int(nullable: false, identity: true),
                        UrunName = c.String(),
                        UruntDescription = c.String(),
                        UrunPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UrunImageUrl = c.String(),
                        UrunIsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UrdunID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Urunlers");
        }
    }
}
