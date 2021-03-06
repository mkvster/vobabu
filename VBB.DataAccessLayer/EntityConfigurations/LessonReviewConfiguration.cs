﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBB.Model;

namespace VBB.DataAccessLayer.EntityConfigurations
{
    public class LessonReviewConfiguration :
        EntityTypeConfiguration<LessonReview>
    {
        public LessonReviewConfiguration()
        {
            Property(lr => lr.Description).HasMaxLength(TextLimits.Memo).IsRequired();
        }
    }
}
