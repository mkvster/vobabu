using System;
using System.Collections.Generic;
namespace VBB.Model
{
    public class Term
    {
        public Term()
        {
            TermPictures = new HashSet<TermPicture>();
            Words = new HashSet<Word>();
            TermTags = new HashSet<TermTag>();
            TermTopics = new HashSet<TermTopic>();
        }

        public int Id { get; set; }

        public bool? IsReadOnly { get; set; }

        public bool? IsBlocked { get; set; }

        //public DateTime DateCreated { get; set; }

        //public DateTime DateUpdated { get; set; }

        public int TermLevelId { get; set; }

        public int TermTypeId { get; set; }

        public string Name { get; set; }

        public string EngText { get; set; }

        public virtual TermLevel TermLevel { get; set; }

        public virtual ICollection<TermPicture> TermPictures { get; set; }

        public virtual TermType TermType { get; set; }

        public virtual ICollection<Word> Words { get; set; }

        public virtual ICollection<TermTag> TermTags { get; set; }

        public virtual ICollection<TermTopic> TermTopics { get; set; }
    }
}
