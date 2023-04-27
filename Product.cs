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
    public partial class Product : Form
    {
        POSTutEntities db = new POSTutEntities();
        string imagePath = "";
        public Product()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtBarcode.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Enter all required data please");
            }
            else
            {
                POSDemo.DB.Product product = new POSDemo.DB.Product();
                product.Name = txtName.Text;
                product.Code = txtBarcode.Text;
                product.Notes = txtNotes.Text;

                // product.Price = decimal.Parse (txtPrice.Text);
                // product.Quantity = int.Parse(txtQty.Text);

                int qty, price;

                int.TryParse(txtQty.Text, out qty);
                int.TryParse(txtPrice.Text, out price); 
                
                product.Quantity = qty;
                product.Price = price;

                db.Products.Add(product);
                db.SaveChanges();
                MessageBox.Show("Product saved");

                if (imagePath != "")
                {
                    string newPath = Environment.CurrentDirectory + "\\images\\products\\" + product.id + ".jpg";
                    File.Copy(imagePath, newPath);

                    product.Images = imagePath;
                    db.SaveChanges();
                }


                txtBarcode.Text = "";
                txtName.Text = "";
                txtQty.Text = "";
                txtPrice.Text = "";
                txtNotes.Text = "";
                pictureBox1.ImageLocation = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
