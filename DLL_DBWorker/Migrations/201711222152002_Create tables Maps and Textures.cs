namespace DLL_DBWorker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatetablesMapsandTextures : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Maps",
                c => new
                    {
                        MapId = c.Int(nullable: false, identity: true),
                        Height = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                        FloorTextures = c.String(),
                        ItemsTextures = c.String(),
                    })
                .PrimaryKey(t => t.MapId);
            
            CreateTable(
                "dbo.Textures",
                c => new
                    {
                        TextureId = c.Int(nullable: false, identity: true),
                        TextureImage = c.Binary(nullable: false),
                    })
                .PrimaryKey(t => t.TextureId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Textures");
            DropTable("dbo.Maps");
        }
    }
}
