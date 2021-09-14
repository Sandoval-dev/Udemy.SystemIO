
namespace SystemIOWİNForm
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstPersonel = new System.Windows.Forms.ListBox();
            this.btnPersonelGetir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.isimbox = new System.Windows.Forms.TextBox();
            this.soyisimbox = new System.Windows.Forms.TextBox();
            this.ulkebox = new System.Windows.Forms.TextBox();
            this.firmabox = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstPersonel);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Liste";
            // 
            // lstPersonel
            // 
            this.lstPersonel.FormattingEnabled = true;
            this.lstPersonel.ItemHeight = 16;
            this.lstPersonel.Location = new System.Drawing.Point(0, 38);
            this.lstPersonel.Name = "lstPersonel";
            this.lstPersonel.Size = new System.Drawing.Size(251, 228);
            this.lstPersonel.TabIndex = 0;
            this.lstPersonel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstPersonel_MouseClick);
            // 
            // btnPersonelGetir
            // 
            this.btnPersonelGetir.Location = new System.Drawing.Point(12, 317);
            this.btnPersonelGetir.Name = "btnPersonelGetir";
            this.btnPersonelGetir.Size = new System.Drawing.Size(257, 57);
            this.btnPersonelGetir.TabIndex = 1;
            this.btnPersonelGetir.Text = "Personel Getir";
            this.btnPersonelGetir.UseVisualStyleBackColor = true;
            this.btnPersonelGetir.Click += new System.EventHandler(this.btnPersonelGetir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Personel Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ülke";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "E mail";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Firma Adı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // isimbox
            // 
            this.isimbox.Location = new System.Drawing.Point(386, 77);
            this.isimbox.Name = "isimbox";
            this.isimbox.ReadOnly = true;
            this.isimbox.Size = new System.Drawing.Size(142, 22);
            this.isimbox.TabIndex = 8;
            // 
            // soyisimbox
            // 
            this.soyisimbox.Location = new System.Drawing.Point(386, 151);
            this.soyisimbox.Name = "soyisimbox";
            this.soyisimbox.ReadOnly = true;
            this.soyisimbox.Size = new System.Drawing.Size(142, 22);
            this.soyisimbox.TabIndex = 9;
            // 
            // ulkebox
            // 
            this.ulkebox.Location = new System.Drawing.Point(386, 246);
            this.ulkebox.Name = "ulkebox";
            this.ulkebox.ReadOnly = true;
            this.ulkebox.Size = new System.Drawing.Size(142, 22);
            this.ulkebox.TabIndex = 10;
            // 
            // firmabox
            // 
            this.firmabox.Location = new System.Drawing.Point(610, 211);
            this.firmabox.Name = "firmabox";
            this.firmabox.ReadOnly = true;
            this.firmabox.Size = new System.Drawing.Size(142, 22);
            this.firmabox.TabIndex = 11;
            this.firmabox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // emailbox
            // 
            this.emailbox.Location = new System.Drawing.Point(610, 109);
            this.emailbox.Name = "emailbox";
            this.emailbox.ReadOnly = true;
            this.emailbox.Size = new System.Drawing.Size(142, 22);
            this.emailbox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 499);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.firmabox);
            this.Controls.Add(this.ulkebox);
            this.Controls.Add(this.soyisimbox);
            this.Controls.Add(this.isimbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPersonelGetir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SystemIO";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstPersonel;
        private System.Windows.Forms.Button btnPersonelGetir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox isimbox;
        private System.Windows.Forms.TextBox soyisimbox;
        private System.Windows.Forms.TextBox ulkebox;
        private System.Windows.Forms.TextBox firmabox;
        private System.Windows.Forms.TextBox emailbox;
    }
}

