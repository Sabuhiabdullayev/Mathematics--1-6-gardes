namespace proje_SIAV
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.riyaziyyatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingilisdiliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.riyaziyyatToolStripMenuItem,
            this.ingilisdiliToolStripMenuItem,
            this.calculatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // riyaziyyatToolStripMenuItem
            // 
            this.riyaziyyatToolStripMenuItem.Name = "riyaziyyatToolStripMenuItem";
            this.riyaziyyatToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.riyaziyyatToolStripMenuItem.Text = "Riyaziyyat";
            // 
            // ingilisdiliToolStripMenuItem
            // 
            this.ingilisdiliToolStripMenuItem.Name = "ingilisdiliToolStripMenuItem";
            this.ingilisdiliToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ingilisdiliToolStripMenuItem.Text = "Rus-dili";
            this.ingilisdiliToolStripMenuItem.Click += new System.EventHandler(this.ingilisdiliToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 481);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingilis-dili";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem riyaziyyatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingilisdiliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
    }
}