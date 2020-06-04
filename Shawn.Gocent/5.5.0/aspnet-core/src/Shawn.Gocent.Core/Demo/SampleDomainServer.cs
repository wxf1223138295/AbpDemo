using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore.Repositories;

namespace Shawn.Gocent.Demo
{
    public class SampleDomainServer:ISampleDomainServer
    {
        private readonly IRepository<Sample> _repository;

        public SampleDomainServer(IRepository<Sample> repository)
        {
            _repository = repository;
        }
        public async Task<bool> AddSampleAsync(Sample entity)
        {
            //todo 业务逻辑
           await _repository.InsertAsync(entity);
           var result = await _repository.GetDbContext().SaveChangesAsync();
           return result > 0;
        }
    }
}
