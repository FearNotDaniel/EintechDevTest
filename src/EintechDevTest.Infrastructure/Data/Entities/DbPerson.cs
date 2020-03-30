using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EintechDevTest.Infrastructure.Data.Entities
{
    public class DbPerson : BaseDbEntity
    {
        public string FullName { get; set; }
        public int GroupID { get; set; }
        public DbGroup Group { get; set; }
    }
}
