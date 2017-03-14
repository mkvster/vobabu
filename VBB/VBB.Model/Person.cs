using System;
using System.Collections.Generic;

namespace VBB.Model
{
    public class Person
    {
        public Person()
        {
            ChangeLogs = new HashSet<ChangeLog>();
            CourseReviews = new HashSet<CourseReview>();
            Courses = new HashSet<Course>();
            PermissionGroups = new HashSet<PermissionGroup>();
        }

        public int Id { get; set; }

        public bool? IsBlocked { get; set; }

        //public DateTime DateCreated { get; set; }

        //public DateTime DateUpdated { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        //public DateTime DateLoggedIn { get; set; }

        public bool? IsTeacher { get; set; }

        public virtual ICollection<ChangeLog> ChangeLogs { get; set; }

        public virtual ICollection<CourseReview> CourseReviews { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        //public virtual ICollection<CourseType> CourseTypes { get; set; }

        //public virtual ICollection<LessonReview> LessonReviews { get; set; }

        //public virtual ICollection<PersonStudy> PersonStudies { get; set; }

        //public virtual ICollection<WordScore> WordScores { get; set; }

        public virtual ICollection<PermissionGroup> PermissionGroups { get; set; }
    }
}
