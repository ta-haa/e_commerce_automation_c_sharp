namespace eticaret_programi
{
    partial class Admin_mesaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_mesaj));
            this.txtmesajeposta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmesaj = new System.Windows.Forms.TextBox();
            this.btnmesajgonder = new System.Windows.Forms.Button();
            this.lblmesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmesajeposta
            // 
            this.txtmesajeposta.Font = new System.Drawing.Font("Hobo Std", 15F, System.Drawing.FontStyle.Bold);
            this.txtmesajeposta.ForeColor = System.Drawing.Color.Red;
            this.txtmesajeposta.Location = new System.Drawing.Point(93, 102);
            this.txtmesajeposta.Multiline = true;
            this.txtmesajeposta.Name = "txtmesajeposta";
            this.txtmesajeposta.Size = new System.Drawing.Size(228, 47);
            this.txtmesajeposta.TabIndex = 0;
            this.txtmesajeposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(144, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eposta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(120, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mesajınız";
            // 
            // txtmesaj
            // 
            this.txtmesaj.Font = new System.Drawing.Font("Hobo Std", 15F, System.Drawing.FontStyle.Bold);
            this.txtmesaj.ForeColor = System.Drawing.Color.Red;
            this.txtmesaj.Location = new System.Drawing.Point(31, 252);
            this.txtmesaj.Multiline = true;
            this.txtmesaj.Name = "txtmesaj";
            this.txtmesaj.Size = new System.Drawing.Size(363, 181);
            this.txtmesaj.TabIndex = 2;
            this.txtmesaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnmesajgonder
            // 
            this.btnmesajgonder.BackColor = System.Drawing.Color.Red;
            this.btnmesajgonder.Font = new System.Drawing.Font("Hobo Std", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnmesajgonder.ForeColor = System.Drawing.Color.Transparent;
            this.btnmesajgonder.Location = new System.Drawing.Point(96, 454);
            this.btnmesajgonder.Name = "btnmesajgonder";
            this.btnmesajgonder.Size = new System.Drawing.Size(228, 60);
            this.btnmesajgonder.TabIndex = 4;
            this.btnmesajgonder.Text = "Gönder";
            this.btnmesajgonder.UseVisualStyleBackColor = false;
            this.btnmesajgonder.Click += new System.EventHandler(this.btnmesajgonder_Click);
            // 
            // lblmesaj
            // 
            this.lblmesaj.AutoSize = true;
            this.lblmesaj.Font = new System.Drawing.Font("Hobo Std", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmesaj.ForeColor = System.Drawing.Color.Transparent;
            this.lblmesaj.Location = new System.Drawing.Point(47, 527);
            this.lblmesaj.Name = "lblmesaj";
            this.lblmesaj.Size = new System.Drawing.Size(0, 33);
            this.lblmesaj.TabIndex = 5;
            // 
            // Admin_mesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(424, 597);
            this.Controls.Add(this.lblmesaj);
            this.Controls.Add(this.btnmesajgonder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmesaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmesajeposta);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_mesaj";
            this.Text = "Admin_mesaj";
            this.Load += new System.EventHandler(this.Admin_mesaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmesajeposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmesaj;
        private System.Windows.Forms.Button btnmesajgonder;
        private System.Windows.Forms.Label lblmesaj;
    }
}