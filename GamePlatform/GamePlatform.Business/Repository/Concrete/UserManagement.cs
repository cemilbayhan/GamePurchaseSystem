using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GamePlatform.Business.Repository.Abstract;
using GamePlatform.Entities;

namespace GamePlatform.Business.Repository.Concrete
{
    public class UserManagement : IRepository<Registration_Customer>
    {
        public void Delete(Registration_Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Registration_Customer Get(Expression<Func<Registration_Customer, bool>> expression)
        {
            using (var db=new GamePlatformEntities())
            {
                return db.Registration_Customer.Where(expression).FirstOrDefault();
            }
        }

        public List<Registration_Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Registration_Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Registration_Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Registration_Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
