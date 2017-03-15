using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBB.Model;

namespace VBB.DataAccessLayer.EntityConfigurations
{
    public class WordSoundConfiguration :
        EntityTypeConfiguration<WordSound>
    {
        public WordSoundConfiguration()
        {
            Property(ws => ws.SoundUrl).HasMaxLength(TextLimits.Url).IsRequired();
        }
    }
}
