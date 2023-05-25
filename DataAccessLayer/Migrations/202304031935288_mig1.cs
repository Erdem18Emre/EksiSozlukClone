namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contents", "WriterID", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contents", "WriterID", c => c.Int(nullable: false));
        }
    }
}
