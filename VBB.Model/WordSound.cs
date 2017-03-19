using System;
using System.Collections.Generic;

namespace VBB.Model
{
    public class WordSound
    {
        public WordSound()
        {
            Lessons = new HashSet<Lesson>();
        }

        public int Id { get; set; }

        public bool? IsReadOnly { get; set; }

        public bool? IsBlocked { get; set; }

        public int WordId { get; set; }

        //public DateTime DateCreated { get; set; }

        //public DateTime DateUpdated { get; set; }

        public virtual Word Word { get; set; }

        public string SoundUrl { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
