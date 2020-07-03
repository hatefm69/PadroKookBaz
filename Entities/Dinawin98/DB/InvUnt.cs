using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Data.Models.DB
{
    public class InvUnt : BaseEntity
    {
        public InvUnt()
        {
            InvDocD = new HashSet<InvDocD>();
            InvGdsTyp = new HashSet<InvGdsTyp>();
            InvUntCnvrt = new HashSet<InvUntCnvrt>();
            InvUntRelated = new HashSet<InvUntRelated>();
            SalDclrPrcD = new HashSet<SalDclrPrcD>();
            SalInvcD = new HashSet<SalInvcD>();
            SalPreInvcD = new HashSet<SalPreInvcD>();
            SalPreInvcSrvD = new HashSet<SalPreInvcSrvD>();
            SalRequestD = new HashSet<SalRequestD>();
            SalRetInvcD = new HashSet<SalRetInvcD>();
            SalePreInvoiceDetail = new HashSet<SalePreInvoiceDetail>();
        }

        public int InvUntSi { get; set; }
        public string InvUntCu { get; set; }
        public string InvUntTp { get; set; }

        public virtual ICollection<InvDocD> InvDocD { get; set; }
        public virtual ICollection<InvGdsTyp> InvGdsTyp { get; set; }
        public virtual ICollection<InvUntCnvrt> InvUntCnvrt { get; set; }
        public virtual ICollection<InvUntRelated> InvUntRelated { get; set; }
        public virtual ICollection<SalDclrPrcD> SalDclrPrcD { get; set; }
        public virtual ICollection<SalInvcD> SalInvcD { get; set; }
        public virtual ICollection<SalPreInvcD> SalPreInvcD { get; set; }
        public virtual ICollection<SalPreInvcSrvD> SalPreInvcSrvD { get; set; }
        public virtual ICollection<SalRequestD> SalRequestD { get; set; }
        public virtual ICollection<SalRetInvcD> SalRetInvcD { get; set; }
        public virtual ICollection<SalePreInvoiceDetail> SalePreInvoiceDetail { get; set; }
        public virtual ICollection<InvGds> InvGds { get; set; }
    }
    internal class InvUntConfiguration : IEntityTypeConfiguration<InvUnt>
    {
        public void Configure(EntityTypeBuilder<InvUnt> builder)
        {
            builder.Property(p => p.Id).HasColumnName("InvUntSi");
            builder.HasMany(z => z.InvGds).WithOne(z => z.InvUnt).HasForeignKey(z => z.InvUntSi);
        }
    }
}
