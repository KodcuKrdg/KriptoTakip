using Bisuness.Abstract;
using Bisuness.Concrete;
using DataAccess.Concrete.SQLite;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptoTakip.Forms
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            Coin coin = new Coin { Id = 1, Name = "asd" };
            CoinManager coinManager = new CoinManager(new SqliteCoinDal());
            coinManager.Add(coin);

            foreach (var item in coinManager.GetAll())
            {
                MessageBox.Show(coin.Name);
            }
        }
    }
}
