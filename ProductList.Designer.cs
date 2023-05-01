namespace POSDemo
{
    partial class ProductList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtformname = new System.Windows.Forms.TextBox();
            this.txtformbarcode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 595);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.Size = new System.Drawing.Size(973, 818);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(532, 103);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(351, 86);
            this.txtBarcode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Barcode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(387, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(535, 250);
            this.txtName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(348, 86);
            this.txtName.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::POSDemo.Properties.Resources.Refresh_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(612, 435);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 78);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(1328, 802);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 55);
            this.label10.TabIndex = 46;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(1503, 668);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 55);
            this.label9.TabIndex = 45;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(1394, 518);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 55);
            this.label8.TabIndex = 44;
            this.label8.Text = "*";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(2576, 523);
            this.txtQty.Margin = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(673, 76);
            this.txtQty.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2337, 523);
            this.label7.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 55);
            this.label7.TabIndex = 42;
            this.label7.Text = "Quantity";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(1591, 940);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(673, 195);
            this.txtNotes.TabIndex = 41;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(1591, 782);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(673, 87);
            this.txtPrice.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1194, 998);
            this.label6.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 55);
            this.label6.TabIndex = 39;
            this.label6.Text = "Notes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1194, 805);
            this.label5.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 55);
            this.label5.TabIndex = 38;
            this.label5.Text = "Price";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(165)))), ((int)(((byte)(231)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(2036, 1276);
            this.button3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 114);
            this.button3.TabIndex = 37;
            this.button3.Text = "SAVE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2346, 642);
            this.label4.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 55);
            this.label4.TabIndex = 36;
            this.label4.Text = "Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1194, 662);
            this.label3.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 55);
            this.label3.TabIndex = 35;
            this.label3.Text = "Product Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2576, 668);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtformname
            // 
            this.txtformname.Location = new System.Drawing.Point(1591, 656);
            this.txtformname.Margin = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.txtformname.Multiline = true;
            this.txtformname.Name = "txtformname";
            this.txtformname.Size = new System.Drawing.Size(673, 83);
            this.txtformname.TabIndex = 33;
            // 
            // txtformbarcode
            // 
            this.txtformbarcode.Location = new System.Drawing.Point(1591, 514);
            this.txtformbarcode.Margin = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.txtformbarcode.Multiline = true;
            this.txtformbarcode.Name = "txtformbarcode";
            this.txtformbarcode.Size = new System.Drawing.Size(673, 84);
            this.txtformbarcode.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2021, 154);
            this.label11.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(347, 67);
            this.label11.TabIndex = 31;
            this.label11.Text = "Edit Product";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1194, 521);
            this.label12.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 55);
            this.label12.TabIndex = 30;
            this.label12.Text = "Barcode";
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POSDemo.Properties.Resources.peakpx__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(3305, 1543);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtformname);
            this.Controls.Add(this.txtformbarcode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ProductList";
            this.Text = "ProductList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtformname;
        private System.Windows.Forms.TextBox txtformbarcode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}