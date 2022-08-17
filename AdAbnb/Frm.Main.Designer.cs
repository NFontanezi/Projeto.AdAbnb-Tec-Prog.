namespace AdAbnb
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mspMain = new System.Windows.Forms.MenuStrip();
            this.formMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advertisimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advertisimentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdvert = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.txbToAdvert = new System.Windows.Forms.TextBox();
            this.txbToRent = new System.Windows.Forms.TextBox();
            this.mspMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspMain
            // 
            this.mspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMainToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.mspMain.Location = new System.Drawing.Point(0, 0);
            this.mspMain.Name = "mspMain";
            this.mspMain.Size = new System.Drawing.Size(800, 24);
            this.mspMain.TabIndex = 0;
            this.mspMain.Text = "menuStrip1";
            // 
            // formMainToolStripMenuItem
            // 
            this.formMainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advertisimentToolStripMenuItem,
            this.advertisimentToolStripMenuItem1});
            this.formMainToolStripMenuItem.Name = "formMainToolStripMenuItem";
            this.formMainToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.formMainToolStripMenuItem.Text = "Form Main";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // advertisimentToolStripMenuItem
            // 
            this.advertisimentToolStripMenuItem.Name = "advertisimentToolStripMenuItem";
            this.advertisimentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.advertisimentToolStripMenuItem.Text = "To advertise";
            this.advertisimentToolStripMenuItem.Click += new System.EventHandler(this.advertisimentToolStripMenuItem_Click);
            // 
            // advertisimentToolStripMenuItem1
            // 
            this.advertisimentToolStripMenuItem1.Name = "advertisimentToolStripMenuItem1";
            this.advertisimentToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.advertisimentToolStripMenuItem1.Text = "To rent";
            // 
            // btnAdvert
            // 
            this.btnAdvert.Location = new System.Drawing.Point(70, 107);
            this.btnAdvert.Name = "btnAdvert";
            this.btnAdvert.Size = new System.Drawing.Size(316, 199);
            this.btnAdvert.TabIndex = 1;
            this.btnAdvert.Text = "Advertise";
            this.btnAdvert.UseVisualStyleBackColor = true;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(418, 107);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(316, 199);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // txbToAdvert
            // 
            this.txbToAdvert.Location = new System.Drawing.Point(70, 312);
            this.txbToAdvert.Name = "txbToAdvert";
            this.txbToAdvert.Size = new System.Drawing.Size(316, 23);
            this.txbToAdvert.TabIndex = 2;
            this.txbToAdvert.Text = "Click aqui para anunciar!";
            this.txbToAdvert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbToRent
            // 
            this.txbToRent.Location = new System.Drawing.Point(418, 312);
            this.txbToRent.Name = "txbToRent";
            this.txbToRent.Size = new System.Drawing.Size(316, 23);
            this.txbToRent.TabIndex = 2;
            this.txbToRent.Text = "Click aqui para encontrar um lugar!";
            this.txbToRent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbToRent);
            this.Controls.Add(this.txbToAdvert);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnAdvert);
            this.Controls.Add(this.mspMain);
            this.MainMenuStrip = this.mspMain;
            this.Name = "frmMain";
            this.Text = "AdAbnb";
            this.mspMain.ResumeLayout(false);
            this.mspMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mspMain;
        private ToolStripMenuItem formMainToolStripMenuItem;
        private ToolStripMenuItem advertisimentToolStripMenuItem;
        private ToolStripMenuItem advertisimentToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Button btnAdvert;
        private Button btnRent;
        private TextBox txbToAdvert;
        private TextBox txbToRent;
    }
}