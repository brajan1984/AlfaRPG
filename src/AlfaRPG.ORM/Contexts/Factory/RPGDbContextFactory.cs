using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace AlfaRPG.ORM.Contexts.Factory
{
    public class RPGDbContextFactory: IDbContextFactory<RPGDbContext>
    {
        public RPGDbContext Create(DbContextFactoryOptions options)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RPGDbContext>();
            optionsBuilder.UseSqlite("Filename=./rpg.db");

            return new RPGDbContext(optionsBuilder.Options);
        }
    }
}
