namespace eticaret_programi
{
    partial class Admin_Girisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Girisi));
            this.lblgsifre = new System.Windows.Forms.Label();
            this.lblgeposta = new System.Windows.Forms.Label();
            this.txtadminsifre = new System.Windows.Forms.TextBox();
            this.txtadmineposta = new System.Windows.Forms.TextBox();
            this.btnadmingiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblgsifre
            // 
            this.lblgsifre.AutoSize = true;
            this.lblgsifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblgsifre.Font = new System.Drawing.Font("Hobo Std", 25.8F, System.Drawing.FontStyle.Bold);
            this.lblgsifre.ForeColor = System.Drawing.Color.Transparent;
            this.lblgsifre.Location = new System.Drawing.Point(135, 198);
            this.lblgsifre.Name = "lblgsifre";
            this.lblgsifre.Size = new System.Drawing.Size(129, 61);
            this.lblgsifre.TabIndex = 38;
            this.lblgsifre.Text = "Sifre";
            // 
            // lblgeposta
            // 
            this.lblgeposta.AutoSize = true;
            this.lblgeposta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblgeposta.Font = new System.Drawing.Font("Hobo Std", 25.8F, System.Drawing.FontStyle.Bold);
            this.lblgeposta.ForeColor = System.Drawing.Color.Transparent;
            this.lblgeposta.Location = new System.Drawing.Point(116, 46);
            this.lblgeposta.Name = "lblgeposta";
            this.lblgeposta.Size = new System.Drawing.Size(167, 61);
            this.lblgeposta.TabIndex = 37;
            this.lblgeposta.Text = "Eposta";
            // 
            // txtadminsifre
            // 
            this.txtadminsifre.Font = new System.Drawing.Font("Hobo Std", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadminsifre.ForeColor = System.Drawing.Color.Red;
            this.txtadminsifre.Location = new System.Drawing.Point(48, 275);
            this.txtadminsifre.MaxLength = 15;
            this.txtadminsifre.Multiline = true;
            this.txtadminsifre.Name = "txtadminsifre";
            this.txtadminsifre.Size = new System.Drawing.Size(293, 59);
            this.txtadminsifre.TabIndex = 36;
            this.txtadminsifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtadmineposta
            // 
            this.txtadmineposta.Font = new System.Drawing.Font("Hobo Std", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtadmineposta.ForeColor = System.Drawing.Color.Red;
            this.txtadmineposta.Location = new System.Drawing.Point(48, 124);
            this.txtadmineposta.MaxLength = 34;
            this.txtadmineposta.Multiline = true;
            this.txtadmineposta.Name = "txtadmineposta";
            this.txtadmineposta.Size = new System.Drawing.Size(293, 59);
            this.txtadmineposta.TabIndex = 35;
            this.txtadmineposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnadmingiris
            // 
            this.btnadmingiris.BackColor = System.Drawing.Color.Red;
            this.btnadmingiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadmingiris.Font = new System.Drawing.Font("Hobo Std", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmingiris.ForeColor = System.Drawing.Color.Transparent;
            this.btnadmingiris.Location = new System.Drawing.Point(106, 366);
            this.btnadmingiris.Name = "btnadmingiris";
            this.btnadmingiris.Size = new System.Drawing.Size(191, 62);
            this.btnadmingiris.TabIndex = 34;
            this.btnadmingiris.Text = "Giris Yap";
            this.btnadmingiris.UseVisualStyleBackColor = false;
            this.btnadmingiris.Click += new System.EventHandler(this.btnadmingiris_Click);
            // 
            // Admin_Girisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(388, 475);
            this.Controls.Add(this.lblgsifre);
            this.Controls.Add(this.lblgeposta);
            this.Controls.Add(this.txtadminsifre);
            this.Controls.Add(this.txtadmineposta);
            this.Controls.Add(this.btnadmingiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Girisi";
            this.Text = "Admin_Girisi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_Girisi_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Girisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgsifre;
        private System.Windows.Forms.Label lblgeposta;
        private System.Windows.Forms.TextBox txtadminsifre;
        private System.Windows.Forms.TextBox txtadmineposta;
        private System.Windows.Forms.Button btnadmingiris;
    }
}