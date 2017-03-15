using System;
using System.Collections.Generic;

namespace VBB.Model
{
    public class WordScore
    {
        public int Id { get; set; }

        public int PersonId { get; set; }

        public int TouchCount { get; set; }

        public int CorrectCount { get; set; }

        public DateTime DateTouched { get; set; }

        public int WordId { get; set; }

        public virtual Person Person { get; set; }

        public virtual Word Word { get; set; }
    }
}
