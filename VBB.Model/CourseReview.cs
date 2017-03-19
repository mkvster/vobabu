namespace VBB.Model
{

    public class CourseReview
    {
        public int Id { get; set; }

        public bool? IsBlocked { get; set; }

        public int CourseId { get; set; }

        public int StartCount { get; set; }

        public string Description { get; set; }

        public int CreatedById { get; set; }

        public virtual Course Course { get; set; }

        public virtual Person CreatedBy { get; set; }
    }
}
