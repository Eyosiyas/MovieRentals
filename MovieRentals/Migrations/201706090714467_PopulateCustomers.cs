namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Customers values ('John Smith', '19860304',0,1)");
            Sql("insert into Customers (Name, IsSubscribedToNewsletter, MembershipTypeId) values ('Nancy Yates', 1, 3)");
        }
        
        public override void Down()
        {
        }
    }
}
