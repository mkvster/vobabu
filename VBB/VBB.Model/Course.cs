using System;
using System.Collections.Generic;

namespace VBB.Model
{
    public class Course
    {
        public Course()
        {
            CourseReviews = new HashSet<CourseReview>();
            Lessons = new HashSet<Lesson>();
        }

        public int Id { get; set; }

        public bool? IsReadOnly { get; set; }

        public bool? IsBlocked { get; set; }

        //public DateTime DateCreated { get; set; }

        //public DateTime DateUpdated { get; set; }

        public bool? IsActive { get; set; }

        public string Name { get; set; }

        public int CourseTypeId { get; set; }

        public int LanguageId { get; set; }

        public int AuthorId { get; set; }

        public virtual CourseType CourseType { get; set; }

        public virtual Language Language { get; set; }

        public virtual Person Author { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }

        public virtual ICollection<CourseReview> CourseReviews { get; set; }
    }
}
