
using System;
namespace VBB.Model
{

    public class ChangeLog
    {
        public int Id { get; set; }

        public bool? IsReviewed { get; set; }

        public DateTime DateChanged { get; set; }

        public string ChangeType { get; set; }

        public string ObjectType { get; set; }

        public int ObjectId { get; set; }

        public int UpdatedById { get; set; }

        public virtual Person UpdatedBy { get; set; }
    }
}
