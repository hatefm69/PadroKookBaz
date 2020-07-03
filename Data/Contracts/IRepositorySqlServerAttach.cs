using Data.Repositories;
using Entities;

namespace Data
{
    public interface IRepositorySqlServerAttach<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
    }
}