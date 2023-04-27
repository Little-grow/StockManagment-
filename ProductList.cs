﻿using POSDemo.DB;
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
    public partial class ProductList : Form
    {
        POSTutEntities db = new POSTutEntities();
        public ProductList()
        {
            InitializeComponent();

            dataGridView1.DataSource = db.Products.ToList();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = db.Products.Where(x => x.Code == txtBarcode.Text || x.Name.Contains(txtName.Text)).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.ToList();
        }
    }
}
