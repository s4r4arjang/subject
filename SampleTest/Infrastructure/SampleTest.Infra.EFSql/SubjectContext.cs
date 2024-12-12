using Microsoft.EntityFrameworkCore;
using SampleTest.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest.Infra.EFSql
{
    public class SubjectContext :DbContext
    {
        public SubjectContext(DbContextOptions options)
       : base(options)
        {
        }
        public DbSet<Subject> subjects { get; set; }
    }
}
