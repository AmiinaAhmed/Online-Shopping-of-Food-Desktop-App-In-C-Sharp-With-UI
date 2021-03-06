﻿using System;
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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnBackfromAdminLogin_Click(object sender, EventArgs e)
        {
            AdminOrCustomer openForm = new AdminOrCustomer();
            openForm.Show();
            Visible = false;
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            FoodieHome openForm = new FoodieHome();
            openForm.Show();
            Visible = false;
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
    }
}
