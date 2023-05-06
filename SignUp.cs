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

			string folderPath = Environment.CurrentDirectory + "\\imgs\\Users\\";
			string newPath = folderPath + user.id + ".jpg";
			File.Copy(imagePath, newPath);
			

			user.Image = imagePath;
			db.SaveChanges();
			MessageBox.Show("Saved Successfully!");
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				imagePath = dialog.FileName;
				pictureBox1.ImageLocation = dialog.FileName;
			}
		}
	}
}
