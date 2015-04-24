namespace CSC407_FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTopicName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Topics", "TopicName", c => c.String());
            DropColumn("dbo.Posts", "PostTopic");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "PostTopic", c => c.String());
            DropColumn("dbo.Topics", "TopicName");
        }
    }
}
