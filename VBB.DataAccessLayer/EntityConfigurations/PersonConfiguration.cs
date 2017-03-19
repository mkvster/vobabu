using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBB.Model;

namespace VBB.DataAccessLayer.EntityConfigurations
{
    public class PersonConfiguration :
        EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            Property(p => p.FirstName).HasMaxLength(TextLimits.Short).IsOptional();
            Property(p => p.LastName).HasMaxLength(TextLimits.Short).IsOptional();
            Property(p => p.Email).HasMaxLength(TextLimits.Email).IsRequired();
            Property(p => p.UserName).HasMaxLength(TextLimits.Email).IsRequired();
        }
    }
}
