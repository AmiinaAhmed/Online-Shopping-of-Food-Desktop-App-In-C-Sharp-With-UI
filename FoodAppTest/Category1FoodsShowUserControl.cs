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
    public partial class Category1FoodsShowUserControl : UserControl
    {
        FoodsShowUserControl Foods;
        public Category1FoodsShowUserControl()
        {
            InitializeComponent();
        }

        private void btnBackToFoods_Click(object sender, EventArgs e)
        {
            if (Foods != null) Foods.Dispose();
            Foods = new FoodsShowUserControl();
            Controls.Add(Foods);
            Foods.BringToFront();
        }
    }
}
