using System.Data.Entity;
using SchoolDomains;

namespace MvcApplication8.Models
{
    public class MvcApplication8Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<MvcApplication8.Models.MvcApplication8Context>());

        public MvcApplication8Context() : base("name=MvcApplication8Context")
        {
        }

        //public DbSet<Child> Children { get; set; }

        //public DbSet<School> Schools { get; set; }

        public DbSet<Locality> Localities { get; set; }
        public DbSet<SchoolType> SchoolTypes { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<ClassType> ClassTypes { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Child> Children { get; set; }

        public DbSet<Registration> Registrations { get; set; }
        public DbSet<StudyFrom> StudyFroms { get; set; }
        public DbSet<StudyType> StudyTypes { get; set; }
        public DbSet<Employment> Employments { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Relatives> Relatives { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
