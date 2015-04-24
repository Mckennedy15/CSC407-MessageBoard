namespace CSC407_FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedForeignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "TopicId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "TopicId");
        }
    }
}
