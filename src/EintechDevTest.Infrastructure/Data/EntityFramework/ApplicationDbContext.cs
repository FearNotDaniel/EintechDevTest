﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EintechDevTest.Infrastructure.Data.Entities;

namespace EintechDevTest.Infrastructure.Data.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DbGroup> Groups { get; set; }
        public DbSet<DbPerson> People { get; set; }
    }
}
