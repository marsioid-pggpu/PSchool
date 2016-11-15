namespace SchoolPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Localities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ShName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Index = c.String(),
                        Street = c.String(),
                        House = c.String(),
                        House2 = c.String(),
                        Phone = c.String(),
                        Boss = c.String(),
                        Locality_Id = c.Int(nullable: false),
                        SchoolType_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Localities", t => t.Locality_Id, cascadeDelete: true)
                .ForeignKey("dbo.SchoolTypes", t => t.SchoolType_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Locality_Id)
                .Index(t => t.SchoolType_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.SchoolTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        RegDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        Parallel = c.Int(nullable: false),
                        Litera = c.String(),
                        Note = c.String(),
                        ClassType_Id = c.Int(nullable: false),
                        School_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassId)
                .ForeignKey("dbo.ClassTypes", t => t.ClassType_Id, cascadeDelete: true)
                .ForeignKey("dbo.Schools", t => t.School_Id, cascadeDelete: true)
                .Index(t => t.ClassType_Id)
                .Index(t => t.School_Id);
            
            CreateTable(
                "dbo.ClassTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Children",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PatranomicName = c.String(nullable: false),
                        BDate = c.DateTime(nullable: false),
                        Sex = c.Int(nullable: false),
                        Index = c.String(),
                        City = c.String(nullable: false),
                        Street = c.String(nullable: false),
                        House = c.String(nullable: false),
                        House2 = c.String(),
                        Flat = c.String(),
                        Phone = c.String(),
                        Sertifact = c.String(),
                        CC1 = c.Int(),
                        CC2 = c.Int(),
                        CC3 = c.Int(),
                        CC4 = c.Int(),
                        SvSer1 = c.String(),
                        SvSer2 = c.String(),
                        SvNum = c.String(),
                        SvOther = c.String(),
                        Class_ClassId = c.Int(nullable: false),
                        Nationality_Id = c.Int(nullable: false),
                        StudyFrom_Id = c.Int(nullable: false),
                        StudyType_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Class_ClassId, cascadeDelete: true)
                .ForeignKey("dbo.Nationalities", t => t.Nationality_Id, cascadeDelete: true)
                .ForeignKey("dbo.StudyFroms", t => t.StudyFrom_Id, cascadeDelete: true)
                .ForeignKey("dbo.StudyTypes", t => t.StudyType_Id, cascadeDelete: true)
                .Index(t => t.Class_ClassId)
                .Index(t => t.Nationality_Id)
                .Index(t => t.StudyFrom_Id)
                .Index(t => t.StudyType_Id);
            
            CreateTable(
                "dbo.Nationalities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudyFroms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudyTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DateBegin = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Employments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateEmployment = c.DateTime(nullable: false),
                        DateAdd = c.DateTime(nullable: false),
                        DateEdit = c.DateTime(nullable: false),
                        Child_Id = c.Int(nullable: false),
                        Class_ClassId = c.Int(),
                        EmploymentType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.Child_Id, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Class_ClassId)
                .ForeignKey("dbo.EmploymentTypes", t => t.EmploymentType_Id)
                .Index(t => t.Child_Id)
                .Index(t => t.Class_ClassId)
                .Index(t => t.EmploymentType_Id);
            
            CreateTable(
                "dbo.EmploymentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Histories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TextHistory = c.String(),
                        OrderNum = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                        RealDate = c.DateTime(nullable: false),
                        LastSchoolId = c.Int(nullable: false),
                        Child_Id = c.Int(),
                        School_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.Child_Id)
                .ForeignKey("dbo.Schools", t => t.School_Id)
                .Index(t => t.Child_Id)
                .Index(t => t.School_Id);
            
            CreateTable(
                "dbo.Relatives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        LastName = c.String(),
                        PatranomicName = c.String(),
                        BDate = c.DateTime(nullable: false),
                        City = c.String(),
                        Street = c.String(),
                        House = c.String(),
                        House2 = c.String(),
                        Flat = c.String(),
                        Phone = c.String(),
                        Sex = c.Int(nullable: false),
                        Relative = c.String(),
                        Child_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Children", t => t.Child_Id, cascadeDelete: true)
                .Index(t => t.Child_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Relatives", new[] { "Child_Id" });
            DropIndex("dbo.Histories", new[] { "School_Id" });
            DropIndex("dbo.Histories", new[] { "Child_Id" });
            DropIndex("dbo.Employments", new[] { "EmploymentType_Id" });
            DropIndex("dbo.Employments", new[] { "Class_ClassId" });
            DropIndex("dbo.Employments", new[] { "Child_Id" });
            DropIndex("dbo.Registrations", new[] { "Id" });
            DropIndex("dbo.Children", new[] { "StudyType_Id" });
            DropIndex("dbo.Children", new[] { "StudyFrom_Id" });
            DropIndex("dbo.Children", new[] { "Nationality_Id" });
            DropIndex("dbo.Children", new[] { "Class_ClassId" });
            DropIndex("dbo.Classes", new[] { "School_Id" });
            DropIndex("dbo.Classes", new[] { "ClassType_Id" });
            DropIndex("dbo.Schools", new[] { "User_Id" });
            DropIndex("dbo.Schools", new[] { "SchoolType_Id" });
            DropIndex("dbo.Schools", new[] { "Locality_Id" });
            DropForeignKey("dbo.Relatives", "Child_Id", "dbo.Children");
            DropForeignKey("dbo.Histories", "School_Id", "dbo.Schools");
            DropForeignKey("dbo.Histories", "Child_Id", "dbo.Children");
            DropForeignKey("dbo.Employments", "EmploymentType_Id", "dbo.EmploymentTypes");
            DropForeignKey("dbo.Employments", "Class_ClassId", "dbo.Classes");
            DropForeignKey("dbo.Employments", "Child_Id", "dbo.Children");
            DropForeignKey("dbo.Registrations", "Id", "dbo.Children");
            DropForeignKey("dbo.Children", "StudyType_Id", "dbo.StudyTypes");
            DropForeignKey("dbo.Children", "StudyFrom_Id", "dbo.StudyFroms");
            DropForeignKey("dbo.Children", "Nationality_Id", "dbo.Nationalities");
            DropForeignKey("dbo.Children", "Class_ClassId", "dbo.Classes");
            DropForeignKey("dbo.Classes", "School_Id", "dbo.Schools");
            DropForeignKey("dbo.Classes", "ClassType_Id", "dbo.ClassTypes");
            DropForeignKey("dbo.Schools", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Schools", "SchoolType_Id", "dbo.SchoolTypes");
            DropForeignKey("dbo.Schools", "Locality_Id", "dbo.Localities");
            DropTable("dbo.Relatives");
            DropTable("dbo.Histories");
            DropTable("dbo.EmploymentTypes");
            DropTable("dbo.Employments");
            DropTable("dbo.Registrations");
            DropTable("dbo.StudyTypes");
            DropTable("dbo.StudyFroms");
            DropTable("dbo.Nationalities");
            DropTable("dbo.Children");
            DropTable("dbo.ClassTypes");
            DropTable("dbo.Classes");
            DropTable("dbo.Users");
            DropTable("dbo.SchoolTypes");
            DropTable("dbo.Schools");
            DropTable("dbo.Localities");
        }
    }
}
