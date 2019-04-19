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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnBackfromUserRegistration_Click(object sender, EventArgs e)
        {
            UserLogin openForm = new UserLogin();
            openForm.Show();
            Visible = false;
        }

        private void btnUserRegistration_Click(object sender, EventArgs e)
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
