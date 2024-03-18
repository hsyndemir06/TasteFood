namespace TesteFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addContactIsRead : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "IsRead", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "IsRead");
        }
    }
}
