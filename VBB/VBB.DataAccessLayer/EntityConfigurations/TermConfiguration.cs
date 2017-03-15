using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBB.Model;

namespace VBB.DataAccessLayer.EntityConfigurations
{
    public class TermConfiguration :
        EntityTypeConfiguration<Term>
    {
        public TermConfiguration()
        {
            Property(t => t.Name).HasMaxLength(TextLimits.Short).IsRequired();
            Property(t => t.EngText).HasMaxLength(TextLimits.Phrase).IsRequired();
        }
    }
}
