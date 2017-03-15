using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBB.Model;

namespace VBB.DataAccessLayer.EntityConfigurations
{
    public class PermissionGroupConfiguration :
        EntityTypeConfiguration<PermissionGroup>
    {
        public PermissionGroupConfiguration()
        {
            Property(pg => pg.Name).HasMaxLength(TextLimits.Title).IsRequired();
            Property(pg => pg.Description).HasMaxLength(TextLimits.Memo).IsOptional();
        }
    }
}
