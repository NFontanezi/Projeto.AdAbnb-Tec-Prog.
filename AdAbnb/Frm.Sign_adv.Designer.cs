namespace AdAbnb.Presentation
{
    partial class FormSign_adv
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
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(80, 88);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(277, 198);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "Cadastre-se!";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click_1);
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(398, 88);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(277, 198);
            this.btnSign.TabIndex = 0;
            this.btnSign.Text = "Login!";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(274, 351);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(205, 39);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Voltar ao Menu Principal";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormSign_adv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnRegistration);
            this.Name = "FormSign_adv";
            this.Text = "FormSign_adv";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRegistration;
        private Button btnSign;
        private Button btnBack;
    }
}