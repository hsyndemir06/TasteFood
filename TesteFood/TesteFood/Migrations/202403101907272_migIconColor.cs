namespace TesteFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migIconColor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifacations", "IconCircleColor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notifacations", "IconCircleColor");
        }
    }
}
