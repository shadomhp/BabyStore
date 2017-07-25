namespace BabyStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniqueFileName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductImages", "Filename", c => c.String(maxLength: 100));
            CreateIndex("dbo.ProductImages", "Filename", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.ProductImages", new[] { "Filename" });
            AlterColumn("dbo.ProductImages", "Filename", c => c.String());
        }
    }
}
