namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_publicıdchange : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Headings", name: "Writer_PublicID", newName: "PublicID");
            RenameColumn(table: "dbo.Contents", name: "Writer_PublicID", newName: "PublicID");
            RenameIndex(table: "dbo.Headings", name: "IX_Writer_PublicID", newName: "IX_PublicID");
            RenameIndex(table: "dbo.Contents", name: "IX_Writer_PublicID", newName: "IX_PublicID");
            DropColumn("dbo.Headings", "WriterID");
            DropColumn("dbo.Contents", "WriterID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contents", "WriterID", c => c.Int());
            AddColumn("dbo.Headings", "WriterID", c => c.Int());
            RenameIndex(table: "dbo.Contents", name: "IX_PublicID", newName: "IX_Writer_PublicID");
            RenameIndex(table: "dbo.Headings", name: "IX_PublicID", newName: "IX_Writer_PublicID");
            RenameColumn(table: "dbo.Contents", name: "PublicID", newName: "Writer_PublicID");
            RenameColumn(table: "dbo.Headings", name: "PublicID", newName: "Writer_PublicID");
        }
    }
}
