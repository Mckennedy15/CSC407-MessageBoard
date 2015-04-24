namespace CSC407_FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changedstuff : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        PostTopic = c.String(),
                        PostUser = c.String(),
                        PostMessage = c.String(),
                    })
                .PrimaryKey(t => t.PostId);
            
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        TopicId = c.Int(nullable: false, identity: true),
                        TopicMessage = c.String(),
                        TopicUser = c.String(),
                    })
                .PrimaryKey(t => t.TopicId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Topics");
            DropTable("dbo.Posts");
        }
    }
}
