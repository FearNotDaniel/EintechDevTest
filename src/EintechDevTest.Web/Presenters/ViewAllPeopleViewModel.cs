﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EintechDevTest.Core.Domain.Entities;

namespace EintechDevTest.Web.Presenters
{
    public class ViewAllPeopleViewModel
    {
        public IEnumerable<Person> People { get; set; }
    }
}
