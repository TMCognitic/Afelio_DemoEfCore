using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afelio_DemoEfCore.Domain.Configurations
{
    internal abstract class Configuration<T> : IEntityTypeConfiguration<T>
        where T : class
    {
        public abstract void Configure(EntityTypeBuilder<T> builder);
    }
}
