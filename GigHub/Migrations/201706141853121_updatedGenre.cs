namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedGenre : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Gigs", new[] { "Genre_ID" });
            CreateIndex("dbo.Gigs", "Genre_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Gigs", new[] { "Genre_Id" });
            CreateIndex("dbo.Gigs", "Genre_ID");
        }
    }
}
