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
    public partial class FoodsShowUserControl : UserControl
    {
        Category1FoodsShowUserControl UserControl1;
        Category2FoodsShowUserControl UserControl2;
        Category3FoodsShowUserControl UserControl3;
        Category4FoodsShowUserControl UserControl4;
        public FoodsShowUserControl()
        {
            InitializeComponent();
        }

        private void btnCategory1_Click(object sender, EventArgs e)
        {
            if (UserControl3 != null) UserControl3.Dispose();
            UserControl3 = new Category3FoodsShowUserControl();
            Controls.Add(UserControl3);
            UserControl3.BringToFront();
        }

        private void btnCategory2_Click(object sender, EventArgs e)
        {
            if (UserControl1 != null) UserControl1.Dispose();
            UserControl1 = new Category1FoodsShowUserControl();
            Controls.Add(UserControl1);
            UserControl1.BringToFront();
           
        }

        private void btnCategory3_Click(object sender, EventArgs e)
        {
            if (UserControl2 != null) UserControl2.Dispose();
            UserControl2 = new Category2FoodsShowUserControl();
            Controls.Add(UserControl2);
            UserControl2.BringToFront();
        }

        private void btnCategory4_Click(object sender, EventArgs e)
        {
            if (UserControl4 != null) UserControl4.Dispose();
            UserControl4 = new Category4FoodsShowUserControl();
            Controls.Add(UserControl4);
            UserControl4.BringToFront();
        }
    }
}
