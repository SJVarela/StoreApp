using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance.Data.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasOne(i => i.Product).WithMany().HasForeignKey(i => i.ProductId);
            builder.Property(i => i.Price).IsRequired();
            builder.Property(i => i.Quantity).IsRequired();
        }
    }
}
