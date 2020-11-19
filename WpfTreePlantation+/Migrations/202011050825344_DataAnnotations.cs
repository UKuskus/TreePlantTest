namespace WpfTreePlantation_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "Login", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Accounts", "Password", c => c.String(maxLength: 256));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "Password", c => c.String());
            AlterColumn("dbo.Accounts", "Login", c => c.String());
        }
    }
}
