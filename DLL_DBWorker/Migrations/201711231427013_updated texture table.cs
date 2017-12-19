namespace DLL_DBWorker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedtexturetable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Textures", "HashSum", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Textures", "HashSum");
        }
    }
}
