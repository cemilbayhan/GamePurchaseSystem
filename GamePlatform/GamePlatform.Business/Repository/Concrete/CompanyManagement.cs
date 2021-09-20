using GamePlatform.Business.Repository.Abstract;
using GamePlatform.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GamePlatform.Business.Repository.Concrete
{
    public class CompanyManagement : IRepository<Registration_Company>
    {
        public void Delete(Registration_Company entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Registration_Company Get(Expression<Func<Registration_Company, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<Registration_Company> GetAll()
        {
            using (var db=new GamePlatformEntities())
            {
                return db.Registration_Company.ToList();
            }
        }

        public Registration_Company GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Registration_Company entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Registration_Company entity)
        {
            throw new NotImplementedException();
        }
    }
}
