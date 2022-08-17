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
            this.advertisimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advertisimentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdvert = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.txbToAdvert = new System.Windows.Forms.TextBox();
            this.txbToRent = new System.Windows.Forms.TextBox();
            this.btnAdvert2 = new System.Windows.Forms.Button();
            this.btnRent2 = new System.Windows.Forms.Button();
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
            // advertisimentToolStripMenuItem
            // 
            this.advertisimentToolStripMenuItem.Name = "advertisimentToolStripMenuItem";
            this.advertisimentToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.advertisimentToolStripMenuItem.Text = "To advertise";
            this.advertisimentToolStripMenuItem.Click += new System.EventHandler(this.advertisimentToolStripMenuItem_Click);
            // 
            // advertisimentToolStripMenuItem1
            // 
            this.advertisimentToolStripMenuItem1.Name = "advertisimentToolStripMenuItem1";
            this.advertisimentToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.advertisimentToolStripMenuItem1.Text = "To rent";
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
            // btnAdvert
            // 
            this.btnAdvert.Location = new System.Drawing.Point(70, 107);
            this.btnAdvert.Name = "btnAdvert";
            this.btnAdvert.Size = new System.Drawing.Size(316, 199);
            this.btnAdvert.TabIndex = 1;
            this.btnAdvert.Text = "Advertise";
            this.btnAdvert.UseVisualStyleBackColor = true;
            this.btnAdvert.Click += new System.EventHandler(this.btnAdvert_Click);
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
            this.txbToAdvert.Location = new System.Drawing.Point(70, 353);
            this.txbToAdvert.Name = "txbToAdvert";
            this.txbToAdvert.Size = new System.Drawing.Size(316, 23);
            this.txbToAdvert.TabIndex = 2;
            this.txbToAdvert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbToRent
            // 
            this.txbToRent.Location = new System.Drawing.Point(418, 353);
            this.txbToRent.Name = "txbToRent";
            this.txbToRent.Size = new System.Drawing.Size(316, 23);
            this.txbToRent.TabIndex = 4;
            // 
            // btnAdvert2
            // 
            this.btnAdvert2.Location = new System.Drawing.Point(69, 309);
            this.btnAdvert2.Name = "btnAdvert2";
            this.btnAdvert2.Size = new System.Drawing.Size(316, 25);
            this.btnAdvert2.TabIndex = 3;
            this.btnAdvert2.Text = "Click aqui para anunciar!";
            this.btnAdvert2.UseVisualStyleBackColor = true;
            this.btnAdvert2.Click += new System.EventHandler(this.btnAdvert2_Click);
            // 
            // btnRent2
            // 
            this.btnRent2.Location = new System.Drawing.Point(418, 309);
            this.btnRent2.Name = "btnRent2";
            this.btnRent2.Size = new System.Drawing.Size(316, 25);
            this.btnRent2.TabIndex = 3;
            this.btnRent2.Text = "Click aqui para encontrar um lugar!";
            this.btnRent2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRent2);
            this.Controls.Add(this.btnAdvert2);
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
        private Button btnAdvert2;
        private Button btnRent2;
    }
}