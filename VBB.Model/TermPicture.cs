using System;
using System.Collections.Generic;

namespace VBB.Model
{
    public class TermPicture
    {
        public TermPicture()
        {
            Lessons = new HashSet<Lesson>();
        }

        public int Id { get; set; }

        public bool? IsReadOnly { get; set; }

        public bool? IsBlocked { get; set; }

        public int TermId { get; set; }

        public string ImageUrl { get; set; }

        public bool? IsTransparent { get; set; }

        //public DateTime DateCreated { get; set; }

        //public DateTime DateUpdated { get; set; }

        public virtual Term Term { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
