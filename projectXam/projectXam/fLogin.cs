using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectXam
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("user") && txtPass.Text.Equals("pass"))
            {
                this.Hide();
                fMenu menu = new fMenu();
                menu.ShowDialog();
                txtPass.Clear();
                this.Show();
                
            }
        }
    }
}
