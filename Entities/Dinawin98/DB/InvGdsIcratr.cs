using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public class InvGdsIcratr:BaseEntity
    {
        public int InvGdsIcratrSi { get; set; }
        public string InvGdsIcratrTp { get; set; }
        public string InvGdsIcratrCu { get; set; }
        public IEnumerable<InvGds> InvGds { get; set; }
    }
    internal class InvGdsICratrConfiguration : IEntityTypeConfiguration<InvGdsIcratr>
    {
        public void Configure(EntityTypeBuilder<InvGdsIcratr> builder)
        {
            builder.Property(p => p.Id).HasColumnName("InvGdsICratr_Si");
            builder.HasMany(z => z.InvGds).WithOne(z => z.InvGdsICratr).HasForeignKey(z => z.InvGdsIcratrSi);
        }
    }
}
