using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBB.Model;

namespace VBB.DataAccessLayer.EntityConfigurations
{
    public class WordConfiguration :
        EntityTypeConfiguration<Word>
    {
        public WordConfiguration()
        {
            Property(w => w.Text).HasMaxLength(TextLimits.Phrase).IsRequired();
        }
    }
}
