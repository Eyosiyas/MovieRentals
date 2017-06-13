namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres values (1,'Adventure')");
            Sql("insert into Genres values (2,'Action')");
            Sql("insert into Genres values (3,'Comedy')");
            Sql("insert into Genres values (4,'Family')");
            Sql("insert into Genres values (5,'Horror')");
            Sql("insert into Genres values (6,'Suspense')");
        }
        
        public override void Down()
        {
        }
    }
}
