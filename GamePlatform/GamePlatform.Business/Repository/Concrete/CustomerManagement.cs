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
    public class CustomerManagement : IRepository<Registration_Customer>
    {
        public void Delete(Registration_Customer entity)
        {
            using (var db = new GamePlatformEntities())
            {
                db.Registration_Customer.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new GamePlatformEntities())
            {
                var entity = db.Registration_Customer.Find(id);
                db.Registration_Customer.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Registration_Customer Get(Expression<Func<Registration_Customer, bool>> expression)
        {
            using (var db = new GamePlatformEntities())
            {
                return db.Registration_Customer.Where(expression).FirstOrDefault();
            }
        }

        public List<Registration_Customer> GetAll()
        {
            using (var db=new GamePlatformEntities())
            {
                return db.Registration_Customer.ToList();
            }
        }

        public Registration_Customer GetById(int id)
        {
            using (var db = new GamePlatformEntities())
            {
                return db.Registration_Customer.Find(id);
            }
        }

        public void Insert(Registration_Customer entity)
        {
            using (var db=new GamePlatformEntities())
            {
                db.Registration_Customer.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(Registration_Customer entity)
        {
            using (var db = new GamePlatformEntities())
            {
                db.Registration_Customer.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
