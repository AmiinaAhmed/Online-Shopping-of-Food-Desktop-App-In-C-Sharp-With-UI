using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodAppTest
{
    public partial class FoodieHome : Form
    {
        public FoodieHome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pnlOnHomeBtn.Height = btnHome.Height;
            pnlOnHomeBtn.Top = btnHome.Top;
            homeShowUserControl1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlOnHomeBtn.Height = btnHome.Height;
            pnlOnHomeBtn.Top = btnHome.Top;
            homeShowUserControl1.BringToFront();
        }

        private void btnOffers_Click(object sender, EventArgs e)
        {
            pnlOnHomeBtn.Height = btnOffers.Height;
            pnlOnHomeBtn.Top = btnOffers.Top;
            offersShowUserControl1.BringToFront();
        }

        private void picBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            pnlOnHomeBtn.Height = btnFoods.Height;
            pnlOnHomeBtn.Top = btnFoods.Top;
            foodsShowUserControl1.BringToFront();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            pnlOnHomeBtn.Height = btnDrinks.Height;
            pnlOnHomeBtn.Top = btnDrinks.Top;
            drinksShowUserControl1.BringToFront();
        }
        private void btnMyCart_Click(object sender, EventArgs e)
        {
            pnlOnHomeBtn.Height = btnMyCart.Height;
            pnlOnHomeBtn.Top = btnMyCart.Top;
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            pnlOnHomeBtn.Height = btnMyOrders.Height;
            pnlOnHomeBtn.Top = btnMyOrders.Top;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlOnHomeBtn.Height = btnSettings.Height;
            pnlOnHomeBtn.Top = btnSettings.Top;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserLogin openForm = new UserLogin();
            openForm.Show();
            Visible = false;
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            pnlOnHomeBtn.Height = btnDesserts.Height;
            pnlOnHomeBtn.Top = btnDesserts.Top;
            dessertsShowUserControl1.BringToFront();

        }

        private void picBoxMinMize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
           else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void picBoxMaxMize_Click(object sender, EventArgs e)
        {
            if (WindowState== FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void MouseMove_ToChange(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void MouseDown_ToChange(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            aboutUsShowUserControl1.BringToFront();
        }

       
    }
}
