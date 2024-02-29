namespace proje_SIAV
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.sayi1 = new System.Windows.Forms.Label();
            this.sayi2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnsayideyis = new System.Windows.Forms.Button();
            this.btncavab = new System.Windows.Forms.Button();
            this.sehvcavab = new System.Windows.Forms.Label();
            this.duzcavab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_islem = new System.Windows.Forms.Label();
//            this.btn_calculator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // sayi1
            // 
            this.sayi1.AutoSize = true;
            this.sayi1.Location = new System.Drawing.Point(17, 93);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(30, 22);
            this.sayi1.TabIndex = 0;
            this.sayi1.Text = "00";
            // 
            // sayi2
            // 
            this.sayi2.AutoSize = true;
            this.sayi2.Location = new System.Drawing.Point(17, 180);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(30, 22);
            this.sayi2.TabIndex = 1;
            this.sayi2.Text = "00";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(15, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 33);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(90, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 38);
            this.textBox1.TabIndex = 3;
            // 
            // btnsayideyis
            // 
            this.btnsayideyis.BackColor = System.Drawing.Color.Orange;
            this.btnsayideyis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsayideyis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsayideyis.ForeColor = System.Drawing.Color.Blue;
            this.btnsayideyis.Location = new System.Drawing.Point(6, 244);
            this.btnsayideyis.Name = "btnsayideyis";
            this.btnsayideyis.Size = new System.Drawing.Size(136, 36);
            this.btnsayideyis.TabIndex = 4;
            this.btnsayideyis.Text = "Sayi Dəyiştir";
            this.btnsayideyis.UseVisualStyleBackColor = false;
            this.btnsayideyis.Click += new System.EventHandler(this.btnsayideyis_Click);
            // 
            // btncavab
            // 
            this.btncavab.BackColor = System.Drawing.Color.Yellow;
            this.btncavab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncavab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btncavab.ForeColor = System.Drawing.Color.Crimson;
            this.btncavab.Location = new System.Drawing.Point(235, 242);
            this.btncavab.Name = "btncavab";
            this.btncavab.Size = new System.Drawing.Size(124, 36);
            this.btncavab.TabIndex = 5;
            this.btncavab.Text = "Cavab";
            this.btncavab.UseVisualStyleBackColor = false;
            this.btncavab.Click += new System.EventHandler(this.btncavab_Click);
            this.btncavab.Enter += new System.EventHandler(this.btncavab_Enter);
            // 
            // sehvcavab
            // 
            this.sehvcavab.AutoSize = true;
            this.sehvcavab.ForeColor = System.Drawing.Color.DarkRed;
            this.sehvcavab.Location = new System.Drawing.Point(631, 42);
            this.sehvcavab.Name = "sehvcavab";
            this.sehvcavab.Size = new System.Drawing.Size(20, 22);
            this.sehvcavab.TabIndex = 7;
            this.sehvcavab.Text = "0";
        //    this.sehvcavab.Click += new System.EventHandler(this.sehvcavab_Click);
            // 
            // duzcavab
            // 
            this.duzcavab.AutoSize = true;
            this.duzcavab.ForeColor = System.Drawing.Color.DarkRed;
            this.duzcavab.Location = new System.Drawing.Point(631, 8);
            this.duzcavab.Name = "duzcavab";
            this.duzcavab.Size = new System.Drawing.Size(20, 22);
            this.duzcavab.TabIndex = 8;
            this.duzcavab.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(510, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Duz Cavab:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(510, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sehv Cavab:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.pictureBox1.Location = new System.Drawing.Point(162, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(412, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 219);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(210, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tezeden Basla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_islem
            // 
            this.lbl_islem.AutoSize = true;
            this.lbl_islem.BackColor = System.Drawing.Color.White;
            this.lbl_islem.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_islem.Location = new System.Drawing.Point(427, 109);
            this.lbl_islem.Name = "lbl_islem";
            this.lbl_islem.Size = new System.Drawing.Size(0, 22);
            this.lbl_islem.TabIndex = 0;
            // 
            // btn_calculator
            // 
          //  this.btn_calculator.BackColor = System.Drawing.Color.Firebrick;
        //    this.btn_calculator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        //    this.btn_calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        //    this.btn_calculator.ForeColor = System.Drawing.Color.LightSteelBlue;
         //   this.btn_calculator.Location = new System.Drawing.Point(6, 286);
       ///     this.btn_calculator.Name = "btn_calculator";
         //   this.btn_calculator.Size = new System.Drawing.Size(136, 36);
        //    this.btn_calculator.TabIndex = 4;
         //   this.btn_calculator.Text = "Calculator";
         //   this.btn_calculator.UseVisualStyleBackColor = false;
         //   this.btn_calculator.Click += new System.EventHandler(this.btn_calculator);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(247)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(693, 341);
            this.Controls.Add(this.lbl_islem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.duzcavab);
            this.Controls.Add(this.sehvcavab);
            this.Controls.Add(this.btncavab);
       //     this.Controls.Add(this.btn_calculator);
            this.Controls.Add(this.btnsayideyis);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sayi2);
            this.Controls.Add(this.sayi1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Riyaziyyat";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form5_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sayi1;
        private System.Windows.Forms.Label sayi2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnsayideyis;
        private System.Windows.Forms.Button btncavab;
        private System.Windows.Forms.Label sehvcavab;
        private System.Windows.Forms.Label duzcavab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_islem;
   //     private System.Windows.Forms.Button btn_calculator;
    }
}