using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.SQLite
{
    public class SqliteCoinDal : ICoinDal
    {

        public void Add(Coin entity)
        {
            using (SQLiteDbContext context = new SQLiteDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Coin entity)
        {
            using (SQLiteDbContext context = new SQLiteDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Detached;
                context.SaveChanges();
            }
        }

        public List<Coin> GelAll(Expression<Func<Coin, bool>> filter = null)
        {
            using (SQLiteDbContext context = new SQLiteDbContext())
            {
                return filter == null ? context.Set<Coin>().ToList() : context.Set<Coin>().Where(filter).ToList();
            }
        }

        public Coin Get(Expression<Func<Coin, bool>> filter)
        {
            using (SQLiteDbContext context = new SQLiteDbContext())
            {
                return context.Set<Coin>().SingleOrDefault(filter);
            }
        }

        public void Update(Coin entity)
        {
            using (SQLiteDbContext context = new SQLiteDbContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
