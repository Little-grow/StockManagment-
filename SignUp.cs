using POSDemo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace POSDemo
{
	public partial class SignUp : Form
	{
		public POSTutEntities db = new POSTutEntities();
		string imagePath = "";
		public SignUp()
		{
			InitializeComponent();
		
		}

		private void button1_Click(object sender, EventArgs e)
		{
			User user = new User()
			{
				UserName = textBox1.Text,
				Password = textBox2.Text,
				Image = imagePath
			};
			db.Users.Add(user);
			db.SaveChanges();

			if (imagePath != "")
			{
				string newPath = Environment.CurrentDirectory + "\\images\\users\\" + user.id + ".jpg";
				File.Copy(imagePath, newPath);

				user.Image = imagePath;
				db.SaveChanges();

			}



			MessageBox.Show("Done!");
		}
		private void pictureBox1_Click(object sender , EventArgs e)
        {
			OpenFileDialog dialog = new OpenFileDialog();
			if(dialog.ShowDialog() == DialogResult.OK)
            {
				imagePath = dialog.FileName;
				pictureBox1.ImageLocation = dialog.FileName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
