using System.Collections.Generic;

namespace temp.series.interfaces
{
    public interface IRepository<T>
    {
        List<T> FindAll();
        T findById(int id);
        void Insert(T entidade);
        void Delete(int id);
        void update(int id, T entidade);
        int NextId();
    }
}