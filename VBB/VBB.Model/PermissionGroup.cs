using System;
using System.Collections.Generic;

namespace VBB.Model
{
    public class PermissionGroup
    {
        public PermissionGroup()
        {
            Permissions = new HashSet<Permission>();
            Persons = new HashSet<Person>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }

        public virtual ICollection<Person> Persons { get; set; }
    }
}
