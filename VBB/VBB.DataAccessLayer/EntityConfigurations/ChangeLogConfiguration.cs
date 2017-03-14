using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBB.Model;

namespace VBB.DataAccessLayer.EntityConfigurations
{
    public class ChangeLogConfiguration :
        EntityTypeConfiguration<ChangeLog>
    {
        public ChangeLogConfiguration()
        {
            Property(cl => cl.ChangeType).HasMaxLength(TextLimits.Ref).IsRequired();
            Property(cl => cl.ObjectType).HasMaxLength(TextLimits.Ref).IsRequired();
        }
    }
}
