using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using family_hub_prototype.Models;

namespace family_hub_prototype.Data
{
    public class FamilyHubPrototypeContext : DbContext
    {
        public FamilyHubPrototypeContext (DbContextOptions<FamilyHubPrototypeContext> options)
            : base(options)
        {
        }

        public DbSet<family_hub_prototype.Models.Task> Task { get; set; } = default!;
    }
}
