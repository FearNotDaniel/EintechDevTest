using System;
using System.Collections.Generic;
using System.Text;
using EintechDevTest.Infrastructure.Data.EntityFramework.Entities;

namespace EintechDevTest.Infrastructure.Data.Entities
{
    public class Group : BaseEntity
    {
        public string GroupName { get; set; }
    }
}
