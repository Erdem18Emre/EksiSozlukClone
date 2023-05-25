namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Headings", "WriterID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Headings", "WriterID", c => c.Int(nullable: false));
        }
    }
}
