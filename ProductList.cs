using POSDemo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSDemo
{
    public partial class ProductList : Form
    {


        POSTutEntities db = new POSTutEntities();
        int id;
        POSDemo.DB.Product result;
        string imagePath = "";



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
            if (txtName.Text=="")
            {
                dataGridView1.DataSource = db.Products.Where(x => x.Code == txtBarcode.Text).ToList();
            }
            else
            {
                dataGridView1.DataSource = db.Products.Where(x => x.Code == txtBarcode.Text || x.Name.Contains(txtName.Text)).ToList();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            result = db.Products.SingleOrDefault(x => x.id == id);
            txtformbarcode.Text=result.Code;
            txtNotes.Text=result.Notes;
            txtPrice.Text = result.Price.ToString();
            txtQty.Text=result.Quantity.ToString();
            pictureBox1.ImageLocation = result.Images;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            result.Name=txtformname.Text; 
            result.Code=txtformbarcode.Text;
            result.Price=decimal.Parse(txtPrice.Text);
            result.Notes = txtNotes.Text;
            result.Quantity=int.Parse(txtQty.Text);


            db.SaveChanges();
         
            MessageBox.Show("Modified Successfully");
            if (imagePath != "")
            {
                string newPath = Environment.CurrentDirectory + "\\images\\product\\" + result.id + ".jpg";
                File.Copy(imagePath, newPath,true);

                result.Images = imagePath;
                db.SaveChanges();

            }
            dataGridView1.DataSource = db.Products.ToList();

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
