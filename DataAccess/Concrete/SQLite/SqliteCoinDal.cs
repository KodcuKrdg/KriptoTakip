using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<Coin> GelAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
