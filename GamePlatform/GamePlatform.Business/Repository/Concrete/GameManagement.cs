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
    
    public class GameManagement : IRepository<Registration_Game>
    {
        public void Delete(Registration_Game entity)
        {
            using (var db = new GamePlatformEntities())
            {
                db.Registration_Game.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new GamePlatformEntities())
            {
                var entity = db.Registration_Game.Find(id);
                db.Registration_Game.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Registration_Game Get(Expression<Func<Registration_Game, bool>> expression)
        {
            using (var db = new GamePlatformEntities())
            {
                return db.Registration_Game.Where(expression).FirstOrDefault();
            }
        }

        public List<Registration_Game> GetAll()
        {
            using (var db = new GamePlatformEntities())
            {
                return db.Registration_Game.ToList();
            }
        }

        public Registration_Game GetById(int id)
        {
            using (var db = new GamePlatformEntities())
            {
                return db.Registration_Game.Find(id);
            }
        }

        public void Insert(Registration_Game entity)
        {
            using (var db = new GamePlatformEntities())
            {
                db.Registration_Game.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(Registration_Game entity)
        {
            using (var db = new GamePlatformEntities())
            {
                db.Registration_Game.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<SP_GetGames_Result> GetGames()
        {
            using (var db=new GamePlatformEntities())
            {
                return db.SP_GetGames().ToList();
            }
        }
    }
}
