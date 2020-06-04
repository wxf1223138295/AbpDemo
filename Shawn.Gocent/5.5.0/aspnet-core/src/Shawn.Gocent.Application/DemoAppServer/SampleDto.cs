using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Shawn.Gocent.Demo;

namespace Shawn.Gocent.DemoAppServer
{
    [AutoMapFrom(typeof(Sample))]
    public class SampleDto : EntityDto<int>
    {
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string Col4 { get; set; }
        public string Col5 { get; set; }
        public string Col6 { get; set; }
        public string Col7 { get; set; }

    }
}
