using dotnetsln2.Models.Base;
using System.Collections.Generic;

namespace dotnetsln2.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        public T Create(T item);
        public void Delete(long id);
        public T Edit(T item);
        public List<T> FindAll();
        public T FindById(long id);
    }
}
