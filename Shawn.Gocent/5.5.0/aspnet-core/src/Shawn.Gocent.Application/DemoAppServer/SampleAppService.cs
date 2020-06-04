using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using Shawn.Gocent.Demo;

namespace Shawn.Gocent.DemoAppServer
{
    public class SampleAppService : AsyncCrudAppService<Sample, SampleDto, int>, ISampleAppService
    {
        public SampleAppService(IRepository<Sample, int> repository) : base(repository)
        {
        }
    }
}
