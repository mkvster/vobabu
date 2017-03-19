using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBB.Model;

namespace VBB.DataAccessLayer.EntityConfigurations
{
    public class PermissionConfiguration :
        EntityTypeConfiguration<Permission>
    {
        public PermissionConfiguration()
        {
            Property(p => p.FeatureName).HasMaxLength(TextLimits.Ref).IsRequired();
        }
    }
}
