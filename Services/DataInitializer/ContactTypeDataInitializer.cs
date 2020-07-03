using Common.Utilities;
using Data.Repositories;
using Entities.Padro;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;

namespace Services.DataInitializer
{
    /// <summary>
    /// کلاس برای تولید محتوای قرارداد 
    /// </summary>
    public class ContactTypeDataInitializer : IDataInitializer
    {
        private readonly IRepository<ContactType> repository;
        public ContactTypeDataInitializer(IRepository<ContactType> repository)
        {
            this.repository = repository;
        }
        /// <summary>
        /// تولید کننده محتوا
        /// </summary>
        public void InitializeData()
        {
            if (!repository.TableNoTracking.Any())
            {
                repository.AddRange(Enum.GetValues(typeof(ContactTypeEnum))
   .OfType<ContactTypeEnum>().Select(x => new ContactType { Id = x, Value = x.ToDisplay() }).ToArray());
            }
        }
    }
}
