namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ss : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Email", c => c.String());
            AddColumn("dbo.Person", "CreditsEarned", c => c.Int());
            AddColumn("dbo.Person", "Gpa", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Gpa");
            DropColumn("dbo.Person", "CreditsEarned");
            DropColumn("dbo.Person", "Email");
        }
    }
}
