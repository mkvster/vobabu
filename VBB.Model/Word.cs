using System;
using System.Collections.Generic;

namespace VBB.Model
{
    public class Word
    {
        public Word()
        {
            WordScores = new HashSet<WordScore>();
            WordSounds = new HashSet<WordSound>();
            Lessons = new HashSet<Lesson>();
        }

        public int Id { get; set; }

        public bool? IsReadOnly { get; set; }

        public bool? IsBlocked { get; set; }

        //public DateTime DateCreated { get; set; }

        //public DateTime DateUpdated { get; set; }

        public int TermId { get; set; }

        public string Text { get; set; }

        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }

        public virtual Term Term { get; set; }

        public virtual ICollection<WordScore> WordScores { get; set; }

        public virtual ICollection<WordSound> WordSounds { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
