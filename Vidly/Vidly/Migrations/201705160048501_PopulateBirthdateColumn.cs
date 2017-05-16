namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdateColumn : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1995-02-23' AS DATETIME) WHERE Id = 43");
            Sql("UPDATE Customers SET Birthdate = CAST('1997-03-30' AS DATETIME) WHERE Id = 45");

        }
        
        public override void Down()
        {
        }
    }
}
