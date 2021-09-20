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

    public class OrderManagement : IRepository<Buy_Game>
    {
        public void Delete(Buy_Game entity)
        {
            using (var db = new GamePlatformEntities())
            {
                db.Buy_Game.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new GamePlatformEntities())
            {
                var entity = db.Buy_Game.Find(id);
                db.Buy_Game.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Buy_Game Get(Expression<Func<Buy_Game, bool>> expression)
        {
            using (var db = new GamePlatformEntities())
            {
                return db.Buy_Game.Where(expression).FirstOrDefault();
            }
        }

        public Buy_ExtraPackage Get1(Expression<Func<Buy_ExtraPackage, bool>> expression)
        {
            using (var db = new GamePlatformEntities())
            {
                return db.Buy_ExtraPackage.Where(expression).FirstOrDefault();
            }
        }

        public List<Buy_Game> GetAll()
        {
            using (var db = new GamePlatformEntities())
            {
                return db.Buy_Game.ToList();
            }
        }

        public Buy_Game GetById(int id)
        {
            using (var db = new GamePlatformEntities())
            {
                return db.Buy_Game.Find(id);
            }
        }

        public void Insert(Buy_Game entity)
        {
            using (var db = new GamePlatformEntities())
            {
                db.Buy_Game.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(Buy_Game entity)
        {
            using (var db = new GamePlatformEntities())
            {
                db.Buy_Game.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<SP_GetBuyGame1_Result> GetGames()
        {
            using (var db = new GamePlatformEntities())
            {
                return db.SP_GetBuyGame1().ToList();
            }
        }

        public List<SP_GetBuyExtra_Result> GetExtras()
        {
            using (var db = new GamePlatformEntities())
            {
                return db.SP_GetBuyExtra().ToList();
            }
        }

        public void AddOrderGame(Order_Game orderGame) 
        {
            using (var db= new GamePlatformEntities())
            {
                db.Order_Game.Attach(orderGame);
                db.Entry(orderGame).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            }
        }
        public void AddExtra(Order_ExtraPackage orderExtraGame)
        {
            using (var db = new GamePlatformEntities())
            {
                db.Order_ExtraPackage.Attach(orderExtraGame);
                db.Entry(orderExtraGame).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            }
        }

        public Registration_Coupon GetCoupon(Expression<Func<Registration_Coupon, bool>> expression) 
        {
            using (var db = new GamePlatformEntities())
            {
                return db.Registration_Coupon.Where(expression).FirstOrDefault();
            }
        }

    }


}
