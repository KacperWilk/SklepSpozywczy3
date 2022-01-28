namespace SklepSpozywczy3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategory : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CategoryTypes (Id, Name) VALUES (1, 'Piekarnia')");
            Sql("INSERT INTO CategoryTypes (Id, Name) VALUES (2, 'Warzywa')");
        }

        public override void Down()
        {
        }
    }
}
