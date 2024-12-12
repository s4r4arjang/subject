using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest.Core.Domain
{
    public interface ISubjectRepository
    {
        void Add(Subject subject);
        int Save();
    }
}
