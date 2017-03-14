using System;
using System.Collections.Generic;

namespace VBB.Model
{
    public class CourseType
    {
        public CourseType()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        public bool? IsReadOnly { get; set; }

        public bool? IsBlocked { get; set; }

        //public DateTime DateCreated { get; set; }

        //public DateTime DateUpdated { get; set; }

        public string Name { get; set; }

        //public int UpdatedById { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        //public virtual Person UpdatedBy { get; set; }
    }
}
