namespace SklepSpozywczy3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newsletterSubscribed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "newsletterSubscribed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "newsletterSubscribed");
        }
    }
}
