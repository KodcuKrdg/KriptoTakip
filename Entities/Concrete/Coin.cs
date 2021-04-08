using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Coin : ICoin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitBuyPrice { get; set; }
        public short UnitsInStock { get; set; }
        public float Percent { get; set; } //Yüzde
        public int UnitSelPrice { get; set; }
        public decimal Buy { get; set; }
        public decimal Sel { get; set; }
        public decimal ProfitLoss { get; set; } // Kar/Zarar
    }
}
