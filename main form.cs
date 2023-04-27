using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSDemo
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void main_form_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp frm2 = new SignUp();
            frm2.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POSDemo.Product p = new POSDemo.Product();
            p.Show();
        }
    }
}
