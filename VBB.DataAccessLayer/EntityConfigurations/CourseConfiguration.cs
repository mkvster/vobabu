using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBB.Model;

namespace VBB.DataAccessLayer.EntityConfigurations
{
    public class CourseConfiguration :
        EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            Property(c => c.Name).HasMaxLength(TextLimits.Title).IsRequired();
        }
    }
}
