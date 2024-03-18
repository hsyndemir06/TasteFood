namespace TesteFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migNatifation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notifacations",
                c => new
                    {
                        NotifacationID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        IsRead = c.Boolean(nullable: false),
                        NotifacationIcon = c.String(),
                    })
                .PrimaryKey(t => t.NotifacationID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Notifacations");
        }
    }
}
