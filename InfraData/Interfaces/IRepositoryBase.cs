using System.Collections.Generic;
using System.Web.Http.OData;

namespace InfraData.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Patch(Delta<TEntity> newObj, TEntity oldObj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
