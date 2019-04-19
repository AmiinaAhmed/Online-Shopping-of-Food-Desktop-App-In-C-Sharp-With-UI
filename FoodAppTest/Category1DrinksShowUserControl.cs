using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodAppTest
{
    public partial class Category1DrinksShowUserControl : UserControl
    {
        DrinksShowUserControl Drinks;
        public Category1DrinksShowUserControl()
        {
            InitializeComponent();
        }

        private void btnBackToDrinks_Click(object sender, EventArgs e)
        {
            if (Drinks != null) Drinks.Dispose();
            Drinks = new DrinksShowUserControl();
            Controls.Add(Drinks);
            Drinks.BringToFront();
        }
    }
}
