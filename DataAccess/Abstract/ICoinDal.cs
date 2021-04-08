using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICoinDal
    {
        List<Coin> GelAll();
        void Add();
        void Update();
        void Delete();
    }
}
