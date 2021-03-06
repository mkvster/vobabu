using System;
using System.Collections.Generic;

namespace VBB.Model
{
    public class TermType
    {
        public TermType()
        {
            Terms = new HashSet<Term>();
        }

        public int Id { get; set; }

        public bool? IsReadOnly { get; set; }

        public bool? IsBlocked { get; set; }

        //public DateTime DateCreated { get; set; }

        //public DateTime DateUpdated { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Term> Terms { get; set; }
    }
}
