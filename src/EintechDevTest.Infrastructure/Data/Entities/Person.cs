﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EintechDevTest.Infrastructure.Data.EntityFramework.Entities;

namespace EintechDevTest.Infrastructure.Data.Entities
{
    public class Person : BaseEntity
    {
        public string FullName { get; set; }
        public int GroupID { get; set; }
        public Group Group { get; set; }
    }
}
