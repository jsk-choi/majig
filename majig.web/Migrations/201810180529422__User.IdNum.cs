namespace majig.web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _UserIdNum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo._User", "IdNum", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo._User", "IdNum");
        }
    }
}
