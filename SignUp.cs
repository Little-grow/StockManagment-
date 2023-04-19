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

namespace POSDemo
{
	public partial class SignUp : Form
	{
		public POSTutEntities db = new POSTutEntities();	
		
		public SignUp()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			User user = new User()
			{ 
				UserName = textBox1.Text,
				Password = textBox2.Text
			};
			db.Users.Add(user);
			db.SaveChanges();
			MessageBox.Show("Done!");
		}
	
	}
}
