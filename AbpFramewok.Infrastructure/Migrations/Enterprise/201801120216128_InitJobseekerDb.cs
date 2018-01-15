namespace AbpFramewok.Infrastructure.Migrations.Enterprise
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitEnterpriseDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EnterpriseBaseInfo",
                c => new
                    {
                        EnterpriseId = c.Int(nullable: false, identity: true),
                        EnterpriseName = c.String(),
                        LoginName = c.String(),
                        Password = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EnterpriseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EnterpriseBaseInfo");
        }
    }
}
