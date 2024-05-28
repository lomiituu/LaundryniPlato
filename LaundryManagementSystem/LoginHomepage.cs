using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManagementSystem
{
    public partial class LoginHomepage : Form
    {
        public LoginHomepage()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            DASHBOARD DB = new DASHBOARD();
            DB.Show();
            this.Hide();
        }

        private void ForgotPassword_Click(object sender, EventArgs e)
        {
    
        }
    }
}
