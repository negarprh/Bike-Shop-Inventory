using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBike.user
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            if (this.textBoxUserName.Text == "user1" && this.textBoxPassword.Text == "123")
            {
                FormBike myMainForm = new FormBike();
                this.Hide();

                myMainForm.ShowDialog();

                this.Dispose();

            }
            else
            {

                MessageBox.Show("invalid input");
                this.textBoxUserName.Clear(); this.textBoxPassword.Clear();
                this.textBoxUserName.Focus();

            }
        }
    }
}
