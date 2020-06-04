using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shawn.Gocent.Demo
{
    public interface ISampleDomainServer
    {
        Task<bool> AddSampleAsync(Sample entity);
    }
}
