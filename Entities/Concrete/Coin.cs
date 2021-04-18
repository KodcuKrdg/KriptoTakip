using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Coin : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitBuyPrice { get; set; }
        public int UnitsInStock { get; set; }
        public decimal Percent { get; set; } //Yüzde
        public int UnitSelPrice { get; set; }
        public decimal Buy { get; set; }
        public decimal Sel { get; set; }
        public decimal ProfitLoss { get; set; } // Kar/Zarar
    }
}
