using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverEQuality_Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<SilverEQContext>
    {
        public SilverEQContext CreateDbContext(string[] args)
            => new SilverEQContext(DBHelper.Option());
    }
}
