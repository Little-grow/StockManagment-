using POSDemo.DB;
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
	public partial class Welcome : Form
	{
		public Welcome()
		{
			InitializeComponent();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			Thread th = new Thread(OpenFrom1);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Thread th = new Thread(OpenForm2);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
			this.Close();
		}

		void OpenFrom1()
		{
			Application.Run(new Login());
		}

		void OpenForm2()
		{
			Application.Run(new SignUp());
		}
	}
}
