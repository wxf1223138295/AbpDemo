using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Shawn.Gocent.Demo;

namespace Shawn.Gocent.DemoAppServer
{
    public interface ISampleAppService: IAsyncCrudAppService<SampleDto, int>
    {
    }
}
