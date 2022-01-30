using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cs18_paskaita_Store;

namespace StoreFront
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sweetsRepository = new SweetsRepository();
            sweetsRepository.PrintProductData();

            var meatsRepository = new MeatsRepository();
            meatsRepository.PrintProductData();

            var greensRepository = new GreensRepository();
            greensRepository.PrintProductData();

            var drinkablesRepository = new DrinkablesRepository();
            drinkablesRepository.PrintProductData();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sweetsRepository = new SweetsRepository();
            sweetsRepository.PrintProductData();

            var meatsRepository = new MeatsRepository();
            meatsRepository.PrintProductData();

            var greensRepository = new GreensRepository();
            greensRepository.PrintProductData();

            var drinkablesRepository = new DrinkablesRepository();
            drinkablesRepository.PrintProductData();
        }
    }
}
