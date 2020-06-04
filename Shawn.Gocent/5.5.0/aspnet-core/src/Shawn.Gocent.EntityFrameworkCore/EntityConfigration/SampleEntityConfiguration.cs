using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shawn.Gocent.Demo;

namespace Shawn.Gocent.EntityConfigration
{
    class SampleEntityConfiguration : IEntityTypeConfiguration<Sample>
    {
        public void Configure(EntityTypeBuilder<Sample> builder)
        {
            builder.ToTable("Sample");

            //其他配置  主键  对象之间的关系等等 详情见EF文档
        }
    }
}
