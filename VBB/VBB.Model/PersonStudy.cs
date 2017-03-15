using System;
using System.Collections.Generic;

namespace VBB.Model
{
    public class PersonStudy
    {
        public int Id { get; set; }

        public DateTime DateStudy { get; set; }

        public int PersonId { get; set; }

        public int LessonId { get; set; }

        public virtual Lesson Lesson { get; set; }

        public virtual Person Person { get; set; }
    }
}
