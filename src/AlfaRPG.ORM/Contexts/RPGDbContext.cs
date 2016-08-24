using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace AlfaRPG.ORM.Contexts
{
    public class RPGDbContext : DbContext
    {
        public RPGDbContext(DbContextOptions<RPGDbContext> options) : base(options)
        {
        }

        
    }
}
