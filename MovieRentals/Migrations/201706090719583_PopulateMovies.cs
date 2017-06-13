namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Movies values ('Die Hard', '19991212','20080203',3,2)");
            Sql("insert into Movies values ('Hangover', '20080208','20081203',3,3)");
            Sql("insert into Movies values ('Annabel', '20090718','20091023',3,5)");
        }
        
        public override void Down()
        {
        }
    }
}
