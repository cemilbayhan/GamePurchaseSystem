using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GamePlatform.Business.Repository.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T Get(Expression<Func<T, bool>> expression);
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}
