using CrudFixture.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudFixture.Data
{
    public class FixtureContext :DbContext
    { 
        public FixtureContext(DbContextOptions<FixtureContext> options) : base(options)
        {

        }

        public DbSet<Fixture> Fixture { get; set; }
    
    }
}
