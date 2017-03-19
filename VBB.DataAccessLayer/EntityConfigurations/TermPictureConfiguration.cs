using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBB.Model;

namespace VBB.DataAccessLayer.EntityConfigurations
{
    public class TermPictureConfiguration :
        EntityTypeConfiguration<TermPicture>
    {
        public TermPictureConfiguration()
        {
            Property(p => p.ImageUrl).HasMaxLength(TextLimits.Url).IsRequired();
        }
    }
}
