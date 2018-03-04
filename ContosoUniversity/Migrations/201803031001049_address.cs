namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class address : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Address_EmailAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Address_EmailAddress");
        }
    }
}
