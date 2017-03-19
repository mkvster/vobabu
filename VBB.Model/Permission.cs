using System;
using System.Collections.Generic;

namespace VBB.Model
{
    public class Permission
    {
        public int Id { get; set; }

        public string FeatureName { get; set; }

        public int AccessLevel { get; set; }

        public int PermissionGroupId { get; set; }

        public virtual PermissionGroup PermissionGroup { get; set; }
    }
}
