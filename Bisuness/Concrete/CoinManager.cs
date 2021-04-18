using Bisuness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisuness.Concrete
{
    public class CoinManager : ICoinService<Coin>
    {
        ICoinDal _coinDal;

        public CoinManager(ICoinDal coinDal)
        {
            _coinDal = coinDal;
        }

        public void Add(Coin coin)
        {
            _coinDal.Add(coin);
        }

        public void Delete(Coin coin)
        {
            _coinDal.Delete(coin);
        }

        public Coin Get(int id)
        {
            return _coinDal.Get(p => p.Id == id);
        }

        public List<Coin> GetAll()
        {
            return _coinDal.GelAll();
        }

        public void Update(Coin coin)
        {
            _coinDal.Update(coin);
        }
    }
}
