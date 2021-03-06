﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBB.Model;

namespace VBB.DataAccessLayer.EntityConfigurations
{
    public class TermTopicConfiguration :
        EntityTypeConfiguration<TermTopic>
    {
        public TermTopicConfiguration()
        {
            Property(tt => tt.Name).HasMaxLength(TextLimits.Short).IsRequired();
        }
    }
}
