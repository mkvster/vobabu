using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBB.Model;

namespace VBB.DataAccessLayer.EntityConfigurations
{
    public class TermTypeConfiguration :
        EntityTypeConfiguration<TermType>
    {
        public TermTypeConfiguration()
        {
            Property(tt => tt.Name).HasMaxLength(TextLimits.Short).IsRequired();
        }
    }
}
