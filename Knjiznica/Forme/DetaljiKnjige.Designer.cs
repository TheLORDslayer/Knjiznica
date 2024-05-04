namespace Knjiznica.Forme
{
    partial class DetaljiKnjige
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
            this.lbAutor = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbISBN = new System.Windows.Forms.Label();
            this.lbNaslov = new System.Windows.Forms.Label();
            this.lbGodinaIzdanja = new System.Windows.Forms.Label();
            this.lbBrojPrimjeraka = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Location = new System.Drawing.Point(96, 111);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(32, 13);
            this.lbAutor.TabIndex = 0;
            this.lbAutor.Text = "Autor";
            this.lbAutor.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(450, 288);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 31);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(186, 288);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // lbISBN
            // 
            this.lbISBN.AutoSize = true;
            this.lbISBN.Location = new System.Drawing.Point(96, 61);
            this.lbISBN.Name = "lbISBN";
            this.lbISBN.Size = new System.Drawing.Size(32, 13);
            this.lbISBN.TabIndex = 5;
            this.lbISBN.Text = "ISBN\r\n";
            // 
            // lbNaslov
            // 
            this.lbNaslov.AutoSize = true;
            this.lbNaslov.Location = new System.Drawing.Point(96, 167);
            this.lbNaslov.Name = "lbNaslov";
            this.lbNaslov.Size = new System.Drawing.Size(40, 13);
            this.lbNaslov.TabIndex = 6;
            this.lbNaslov.Text = "Naslov";
            // 
            // lbGodinaIzdanja
            // 
            this.lbGodinaIzdanja.AutoSize = true;
            this.lbGodinaIzdanja.Location = new System.Drawing.Point(96, 229);
            this.lbGodinaIzdanja.Name = "lbGodinaIzdanja";
            this.lbGodinaIzdanja.Size = new System.Drawing.Size(78, 13);
            this.lbGodinaIzdanja.TabIndex = 7;
            this.lbGodinaIzdanja.Text = "Godina Izdanja";
            // 
            // lbBrojPrimjeraka
            // 
            this.lbBrojPrimjeraka.AutoSize = true;
            this.lbBrojPrimjeraka.Location = new System.Drawing.Point(96, 291);
            this.lbBrojPrimjeraka.Name = "lbBrojPrimjeraka";
            this.lbBrojPrimjeraka.Size = new System.Drawing.Size(76, 13);
            this.lbBrojPrimjeraka.TabIndex = 8;
            this.lbBrojPrimjeraka.Text = "Broj primjeraka";
            this.lbBrojPrimjeraka.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(338, 20);
            this.textBox3.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(187, 227);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // DetaljiKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 380);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbBrojPrimjeraka);
            this.Controls.Add(this.lbGodinaIzdanja);
            this.Controls.Add(this.lbNaslov);
            this.Controls.Add(this.lbISBN);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbAutor);
            this.Name = "DetaljiKnjige";
            this.Text = "DetaljiKnjige";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbISBN;
        private System.Windows.Forms.Label lbNaslov;
        private System.Windows.Forms.Label lbGodinaIzdanja;
        private System.Windows.Forms.Label lbBrojPrimjeraka;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}