using System;
using System.Collections.Generic;

namespace VBB.Model
{
    public class LessonReview
    {
        public int Id { get; set; }

        public bool? IsBlocked { get; set; }

        public int StartCount { get; set; }

        public string Description { get; set; }

        public int LessonId { get; set; }

        public int CreatedById { get; set; }

        public virtual Lesson Lesson { get; set; }

        public virtual Person CreatedBy { get; set; }
    }
}
