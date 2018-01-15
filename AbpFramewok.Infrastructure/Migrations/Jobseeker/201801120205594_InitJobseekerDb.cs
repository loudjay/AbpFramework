namespace AbpFramewok.Infrastructure.Migrations.Jobseeker
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitJobseekerDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobseekerBaseInfo",
                c => new
                    {
                        JobseekerId = c.Int(nullable: false, identity: true),
                        JobseekerName = c.String(),
                        LoginName = c.String(),
                        Password = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.JobseekerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.JobseekerBaseInfo");
        }
    }
}
