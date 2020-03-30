using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EintechDevTest.Core.Domain.Entities
{
    public class Person : BaseEntity
    {
        public string FullName { get; set; }
        public int GroupID { get; set; }
        public Group Group { get; set; }

        internal Person(string fullName, int groupID, DateTime created, string createdBy, DateTime modified, string modifiedBy, int id = 0, Group group = null)
        {
            FullName = fullName;
            GroupID = groupID;
            Created = created;
            CreatedBy = createdBy;
            Modified = modified;
            ModifiedBy = ModifiedBy;
            ID = id;
            Group = group;
        }
    }
}
