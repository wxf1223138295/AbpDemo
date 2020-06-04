using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shawn.Gocent.DemoAppServer;

namespace Shawn.Gocent.Controllers
{
    [Route("api/[controller]/[action]")]
    public class SampleController: GocentControllerBase
    {
        private readonly ISampleAppService _sampleAppService;

        public SampleController(ISampleAppService sampleAppService)
        {
            _sampleAppService = sampleAppService;
        }
        [HttpPost]
        public async Task<SampleDto> Sample([FromBody] SampleDto model)
        {
            var dto=await _sampleAppService.CreateAsync(model);
            return dto;
        }
    }
}
