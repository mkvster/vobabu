namespace VBB.Model
{
    using System.Collections.Generic;

    public class Language
    {
        public Language()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        public bool? IsReadOnly { get; set; }

        public bool? IsBlocked { get; set; }

        public bool? IsActive { get; set; }

        public string Name { get; set; }

        public string IsoCode { get; set; }

        public string ResCode { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}
