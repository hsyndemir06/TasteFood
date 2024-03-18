namespace TesteFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_TblUrunn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblUruns",
                c => new
                    {
                        TblUrdunID = c.Int(nullable: false, identity: true),
                        TblUrunName = c.String(),
                        TblUruntDescription = c.String(),
                        TblUrunPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TblUrunImageUrl = c.String(),
                        TblUrunIsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TblUrdunID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblUruns");
        }
    }
}
