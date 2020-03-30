using System;
using System.Collections.Generic;
using System.Text;

namespace EintechDevTest.Core.Domain.Entities
{
    public class Group : BaseEntity
    {
        public string GroupName { get; set; }

        public Group(string groupName, DateTime created, string createdBy, DateTime modified, string modifiedBy, int id = 0)
        {
            GroupName = groupName;
            Created = created;
            CreatedBy = createdBy;
            Modified = modified;
            ModifiedBy = ModifiedBy;
            ID = id;
        }
    }
}
