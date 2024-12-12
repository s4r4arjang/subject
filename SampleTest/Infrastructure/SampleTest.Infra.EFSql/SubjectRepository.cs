using SampleTest.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest.Infra.EFSql
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly SubjectContext _Context;
        public SubjectRepository(SubjectContext Context)
        {
            this._Context = Context;
        }
        public void Add(Subject subject)
        {
            _Context.subjects.Add(subject); 
        }

        public int Save()
        {
          return _Context.SaveChanges();
        }
    }
}
