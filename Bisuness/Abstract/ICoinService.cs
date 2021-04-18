using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisuness.Abstract
{
    public interface ICoinService<Coin>
    {
        void Add(Coin coin);
        void Update(Coin coin);
        void Delete(Coin coin);
        List<Coin> GetAll();
        Coin Get(int id);
    }
}
