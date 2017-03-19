using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using VBB.Model;
using System.Data.Entity.ModelConfiguration.Conventions;
using VBB.DataAccessLayer.EntityConfigurations;

namespace VBB.DataAccessLayer
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Word> Words { get; set; }
        public virtual DbSet<TermTopic> TermTopics { get; set; }
        public virtual DbSet<TermType> TermTypes { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<TermTag> TermTags { get; set; }
        public virtual DbSet<TermPicture> TermPictures { get; set; }
        public virtual DbSet<LessonReview> LessonReviews { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PermissionGroup> PermissionGroups { get; set; }
        public virtual DbSet<WordSound> WordSounds { get; set; }
        public virtual DbSet<WordScore> WordScores { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<TermLevel> TermLevels { get; set; }
        public virtual DbSet<CourseReview> CourseReviews { get; set; }
        public virtual DbSet<CourseType> CourseTypes { get; set; }
        public virtual DbSet<PersonStudy> PersonStudies { get; set; }
        public virtual DbSet<ChangeLog> ChangeLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new ChangeLogConfiguration());
            modelBuilder.Configurations.Add(new CourseConfiguration());
            modelBuilder.Configurations.Add(new CourseReviewConfiguration());
            modelBuilder.Configurations.Add(new CourseTypeConfiguration());
            modelBuilder.Configurations.Add(new LanguageConfiguration());
            modelBuilder.Configurations.Add(new LessonConfiguration());
            modelBuilder.Configurations.Add(new LessonReviewConfiguration());
            modelBuilder.Configurations.Add(new PermissionConfiguration());
            modelBuilder.Configurations.Add(new PermissionGroupConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new TermConfiguration());
            modelBuilder.Configurations.Add(new TermLevelConfiguration());
            modelBuilder.Configurations.Add(new TermPictureConfiguration());
            modelBuilder.Configurations.Add(new TermTagConfiguration());
            modelBuilder.Configurations.Add(new TermTopicConfiguration());
            modelBuilder.Configurations.Add(new TermTypeConfiguration());
            modelBuilder.Configurations.Add(new WordConfiguration());
            modelBuilder.Configurations.Add(new WordSoundConfiguration());
        }
    }
}