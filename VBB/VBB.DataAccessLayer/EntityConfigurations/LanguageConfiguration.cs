using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBB.Model;

namespace VBB.DataAccessLayer.EntityConfigurations
{
    public class LanguageConfiguration :
        EntityTypeConfiguration<Language>
    {
        public LanguageConfiguration()
        {
            Property(l => l.Name).HasMaxLength(TextLimits.Title).IsRequired();
            Property(l => l.IsoCode).HasMaxLength(2).IsOptional();
            Property(l => l.ResCode).HasMaxLength(TextLimits.Ref).IsOptional();
        }
    }
}
