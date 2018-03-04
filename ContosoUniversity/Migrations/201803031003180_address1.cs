namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class address1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Person", "Address_EmailAddress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Person", "Address_EmailAddress", c => c.String());
        }
    }
}
