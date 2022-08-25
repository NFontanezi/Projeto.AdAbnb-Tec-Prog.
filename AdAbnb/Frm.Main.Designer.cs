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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mspMain = new System.Windows.Forms.MenuStrip();
            this.formMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advertisimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advertisimentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdvert = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnAdvert2 = new System.Windows.Forms.Button();
            this.btnRent2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mspMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mspMain
            // 
            this.mspMain.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mspMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMainToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.mspMain.Location = new System.Drawing.Point(0, 0);
            this.mspMain.Name = "mspMain";
            this.mspMain.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mspMain.Size = new System.Drawing.Size(914, 28);
            this.mspMain.TabIndex = 0;
            this.mspMain.Text = "menuStrip1";
            // 
            // formMainToolStripMenuItem
            // 
            this.formMainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advertisimentToolStripMenuItem,
            this.advertisimentToolStripMenuItem1});
            this.formMainToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formMainToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.formMainToolStripMenuItem.Name = "formMainToolStripMenuItem";
            this.formMainToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.formMainToolStripMenuItem.Text = "Form Main";
            // 
            // advertisimentToolStripMenuItem
            // 
            this.advertisimentToolStripMenuItem.Name = "advertisimentToolStripMenuItem";
            this.advertisimentToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.advertisimentToolStripMenuItem.Text = "To advertise";
            // 
            // advertisimentToolStripMenuItem1
            // 
            this.advertisimentToolStripMenuItem1.Name = "advertisimentToolStripMenuItem1";
            this.advertisimentToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.advertisimentToolStripMenuItem1.Text = "To rent";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quitToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // btnAdvert
            // 
            this.btnAdvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdvert.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdvert.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdvert.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnAdvert.Location = new System.Drawing.Point(80, 248);
            this.btnAdvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdvert.Name = "btnAdvert";
            this.btnAdvert.Size = new System.Drawing.Size(361, 213);
            this.btnAdvert.TabIndex = 1;
            this.btnAdvert.Text = "ANUNCIE";
            this.btnAdvert.UseVisualStyleBackColor = false;
            this.btnAdvert.Click += new System.EventHandler(this.btnAdvert_Click);
            // 
            // btnRent
            // 
            this.btnRent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRent.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRent.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRent.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRent.Location = new System.Drawing.Point(478, 248);
            this.btnRent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(361, 213);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "ALUGUE";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnAdvert2
            // 
            this.btnAdvert2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdvert2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdvert2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdvert2.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnAdvert2.Location = new System.Drawing.Point(79, 465);
            this.btnAdvert2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdvert2.Name = "btnAdvert2";
            this.btnAdvert2.Size = new System.Drawing.Size(362, 33);
            this.btnAdvert2.TabIndex = 3;
            this.btnAdvert2.Text = "Clique aqui para anunciar um imóvel!";
            this.btnAdvert2.UseVisualStyleBackColor = false;
            this.btnAdvert2.Click += new System.EventHandler(this.btnAdvert2_Click);
            // 
            // btnRent2
            // 
            this.btnRent2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRent2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRent2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRent2.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRent2.Location = new System.Drawing.Point(478, 469);
            this.btnRent2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRent2.Name = "btnRent2";
            this.btnRent2.Size = new System.Drawing.Size(361, 33);
            this.btnRent2.TabIndex = 3;
            this.btnRent2.Text = "Clique aqui para encontrar um lugar!";
            this.btnRent2.UseVisualStyleBackColor = false;
            this.btnRent2.Click += new System.EventHandler(this.btnRent2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 147);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRent2);
            this.Controls.Add(this.btnAdvert2);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnAdvert);
            this.Controls.Add(this.mspMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mspMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdaBnB - Aluguel de casas para temporada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mspMain.ResumeLayout(false);
            this.mspMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Button btnAdvert2;
        private Button btnRent2;
        private ImageList imageList1;
        private PictureBox pictureBox1;
    }
}