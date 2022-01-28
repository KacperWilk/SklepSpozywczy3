namespace SklepSpozywczy3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProducts : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Products (Name, Description, Quantity, CategoryTypeId) VALUES ('Chleb', '200G', 8, 1)");
            Sql("INSERT INTO Products (Name, Description, Quantity, CategoryTypeId) VALUES ('Pomidor', '50G', 54, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
