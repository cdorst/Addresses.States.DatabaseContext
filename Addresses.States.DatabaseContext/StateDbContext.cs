// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Microsoft.EntityFrameworkCore;

namespace Addresses.States.DatabaseContext
{
    /// <summary>EntityFrameworkCore database context for State entities</summary>
    public class StateDbContext : DbContext
    {
        /// <summary>Constructs StateDbContext EntityFrameworkCore database context using given options</summary>
        public StateDbContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>Contains set of State entities</summary>
        public DbSet<State> States { get; set; }

        /// <summary>Configures EntityFramework database creation - adds unique index to model</summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<State>().HasIndex(new State().GetUniqueIndex()).IsUnique();
        }
    }
}
