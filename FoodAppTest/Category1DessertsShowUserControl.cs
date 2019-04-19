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
    public partial class Category1DessertsShowUserControl : UserControl
    {
        DessertsShowUserControl Desserts;
        public Category1DessertsShowUserControl()
        {
            InitializeComponent();
        }

        private void btnBackToDesserts_Click(object sender, EventArgs e)
        {
            if (Desserts != null) Desserts.Dispose();
            Desserts = new DessertsShowUserControl();
            Controls.Add(Desserts);
            Desserts.BringToFront();
        }
    }
}
