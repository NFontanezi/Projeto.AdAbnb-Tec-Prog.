﻿namespace AdAbnb.Presentation
{
    partial class Frm_SignInLogin_rnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SignInLogin_rnt));
            this.btn_Login_rnt = new System.Windows.Forms.Button();
            this.btn_SignIn_rnt = new System.Windows.Forms.Button();
            this.btn_Search_rnt = new System.Windows.Forms.Button();
            this.btn_BackMenu_rnt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Rent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login_rnt
            // 
            this.btn_Login_rnt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Login_rnt.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login_rnt.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Login_rnt.Location = new System.Drawing.Point(100, 216);
            this.btn_Login_rnt.Name = "btn_Login_rnt";
            this.btn_Login_rnt.Size = new System.Drawing.Size(212, 98);
            this.btn_Login_rnt.TabIndex = 0;
            this.btn_Login_rnt.Text = "LogIn";
            this.btn_Login_rnt.UseVisualStyleBackColor = false;
            this.btn_Login_rnt.Click += new System.EventHandler(this.btn_Login_rnt_Click);
            // 
            // btn_SignIn_rnt
            // 
            this.btn_SignIn_rnt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_SignIn_rnt.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SignIn_rnt.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_SignIn_rnt.Location = new System.Drawing.Point(345, 216);
            this.btn_SignIn_rnt.Name = "btn_SignIn_rnt";
            this.btn_SignIn_rnt.Size = new System.Drawing.Size(213, 98);
            this.btn_SignIn_rnt.TabIndex = 1;
            this.btn_SignIn_rnt.Text = "Cadastre-se";
            this.btn_SignIn_rnt.UseVisualStyleBackColor = false;
            this.btn_SignIn_rnt.Click += new System.EventHandler(this.btn_SignIn_rnt_Click);
            // 
            // btn_Search_rnt
            // 
            this.btn_Search_rnt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Search_rnt.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Search_rnt.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Search_rnt.Location = new System.Drawing.Point(589, 216);
            this.btn_Search_rnt.Name = "btn_Search_rnt";
            this.btn_Search_rnt.Size = new System.Drawing.Size(220, 98);
            this.btn_Search_rnt.TabIndex = 2;
            this.btn_Search_rnt.Text = "Procurar imóveis";
            this.btn_Search_rnt.UseVisualStyleBackColor = false;
            // 
            // btn_BackMenu_rnt
            // 
            this.btn_BackMenu_rnt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_BackMenu_rnt.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_BackMenu_rnt.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_BackMenu_rnt.Location = new System.Drawing.Point(345, 370);
            this.btn_BackMenu_rnt.Name = "btn_BackMenu_rnt";
            this.btn_BackMenu_rnt.Size = new System.Drawing.Size(213, 76);
            this.btn_BackMenu_rnt.TabIndex = 3;
            this.btn_BackMenu_rnt.Text = "Voltar ao menu principal";
            this.btn_BackMenu_rnt.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Rent
            // 
            this.lbl_Rent.AutoSize = true;
            this.lbl_Rent.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Rent.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Rent.Location = new System.Drawing.Point(325, 43);
            this.lbl_Rent.Name = "lbl_Rent";
            this.lbl_Rent.Size = new System.Drawing.Size(283, 70);
            this.lbl_Rent.TabIndex = 5;
            this.lbl_Rent.Text = "ALUGUEL";
            // 
            // Frm_SignInLogin_rnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.lbl_Rent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_BackMenu_rnt);
            this.Controls.Add(this.btn_Search_rnt);
            this.Controls.Add(this.btn_SignIn_rnt);
            this.Controls.Add(this.btn_Login_rnt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_SignInLogin_rnt";
            this.Text = "AdaBnb - Aluguel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Login_rnt;
        private Button btn_SignIn_rnt;
        private Button btn_Search_rnt;
        private Button btn_BackMenu_rnt;
        private PictureBox pictureBox1;
        private Label lbl_Rent;
    }
}