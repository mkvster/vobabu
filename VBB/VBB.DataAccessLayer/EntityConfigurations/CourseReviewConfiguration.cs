using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBB.Model;

namespace VBB.DataAccessLayer.EntityConfigurations
{
    public class CourseReviewConfiguration :
        EntityTypeConfiguration<CourseReview>
    {
        public CourseReviewConfiguration()
        {
            Property(cr => cr.Description).HasMaxLength(TextLimits.Memo).IsRequired();
        }
    }
}
