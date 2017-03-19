using System;
using System.Collections.Generic;

namespace VBB.Model
{
    public class Lesson
    {
        public Lesson()
        {
            LessonReviews = new HashSet<LessonReview>();
            PersonStudies = new HashSet<PersonStudy>();
            TermPictures = new HashSet<TermPicture>();
            Words = new HashSet<Word>();
            WordSounds = new HashSet<WordSound>();
        }

        public int Id { get; set; }

        public bool? IsReadOnly { get; set; }

        public bool? IsBlocked { get; set; }

        //public DateTime DateCreated { get; set; }

        //public DateTime DateUpdated { get; set; }

        public bool? IsActive { get; set; }

        public string Name { get; set; }

        public int TermTopicId { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public virtual ICollection<LessonReview> LessonReviews { get; set; }

        public virtual TermTopic TermTopic { get; set; }

        public virtual ICollection<PersonStudy> PersonStudies { get; set; }

        public virtual ICollection<TermPicture> TermPictures { get; set; }

        public virtual ICollection<Word> Words { get; set; }

        public virtual ICollection<WordSound> WordSounds { get; set; }
    }
}
