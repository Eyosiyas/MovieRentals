namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("insert into MembershipTypes values (1,'Pay As You Go', 0, 0, 0)");
            Sql("insert into MembershipTypes values (2,'Monthly', 30, 1, 10)");
            Sql("insert into MembershipTypes values (3,'Quarterly', 90, 3, 15)");
            Sql("insert into MembershipTypes values (4,'Annually', 150, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
