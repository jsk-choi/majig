namespace majig.web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserToUsers : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo._User", newName: "_Users");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo._Users", newName: "_User");
        }
    }
}
