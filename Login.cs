﻿using POSDemo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSDemo
{
	public partial class Login : Form
	{
        POSTutEntities db = new POSTutEntities();
        public Login()
		{
			InitializeComponent();
		}

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var result = db.Users.Where(x => x.UserName == txtUser.Text && x.Password == txtPassword.Text).ToList();

			if (result.Count() > 0)
			{
				main_form mainForm = new main_form(); 
				mainForm.ShowDialog(); 
				this.Close();
			}
			else
			{
                MessageBox.Show("Username or password are invalid");
            }
        }
        
    }
}
