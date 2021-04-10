using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DataAccess.Concrete.SQLite
{
    public class SqliteCoinDal : ICoinDal
    {
        SqliteConnection connection;
        SqliteCommand command;
        public SqliteCoinDal()
        {
            connection = new SqliteConnection("Data Source=Database.db");
            command = connection.CreateCommand();
        }

        public void Add(Coin entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Coin entity)
        {
            throw new NotImplementedException();
        }

        public List<Coin> GelAll(Expression<Func<Coin, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Coin Get(Expression<Func<Coin, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Coin entity)
        {
            throw new NotImplementedException();
        }
    }
}
