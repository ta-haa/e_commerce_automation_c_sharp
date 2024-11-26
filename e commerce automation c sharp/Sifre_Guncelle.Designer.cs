namespace eticaret_programi
{
    partial class Sifre_Guncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sifre_Guncelle));
            this.txtsifreguncelleeski = new System.Windows.Forms.TextBox();
            this.txtsifreguncelleyeni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsifreguncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsifreguncellememail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtsifreguncelleeski
            // 
            this.txtsifreguncelleeski.Font = new System.Drawing.Font("Hobo Std", 15F, System.Drawing.FontStyle.Bold);
            this.txtsifreguncelleeski.ForeColor = System.Drawing.Color.Red;
            this.txtsifreguncelleeski.Location = new System.Drawing.Point(45, 163);
            this.txtsifreguncelleeski.Multiline = true;
            this.txtsifreguncelleeski.Name = "txtsifreguncelleeski";
            this.txtsifreguncelleeski.Size = new System.Drawing.Size(218, 58);
            this.txtsifreguncelleeski.TabIndex = 0;
            this.txtsifreguncelleeski.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsifreguncelleyeni
            // 
            this.txtsifreguncelleyeni.Font = new System.Drawing.Font("Hobo Std", 15F, System.Drawing.FontStyle.Bold);
            this.txtsifreguncelleyeni.ForeColor = System.Drawing.Color.Red;
            this.txtsifreguncelleyeni.Location = new System.Drawing.Point(45, 293);
            this.txtsifreguncelleyeni.Multiline = true;
            this.txtsifreguncelleyeni.Name = "txtsifreguncelleyeni";
            this.txtsifreguncelleyeni.Size = new System.Drawing.Size(218, 53);
            this.txtsifreguncelleyeni.TabIndex = 2;
            this.txtsifreguncelleyeni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(51, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Eski Sifreniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(51, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yeni Sifreniz";
            // 
            // btnsifreguncelle
            // 
            this.btnsifreguncelle.BackColor = System.Drawing.Color.Red;
            this.btnsifreguncelle.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.btnsifreguncelle.ForeColor = System.Drawing.Color.Transparent;
            this.btnsifreguncelle.Location = new System.Drawing.Point(45, 379);
            this.btnsifreguncelle.Name = "btnsifreguncelle";
            this.btnsifreguncelle.Size = new System.Drawing.Size(218, 56);
            this.btnsifreguncelle.TabIndex = 6;
            this.btnsifreguncelle.Text = "Güncelle";
            this.btnsifreguncelle.UseVisualStyleBackColor = false;
            this.btnsifreguncelle.Click += new System.EventHandler(this.btnsifreguncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Eposta";
            // 
            // txtsifreguncellememail
            // 
            this.txtsifreguncellememail.Font = new System.Drawing.Font("Hobo Std", 15F, System.Drawing.FontStyle.Bold);
            this.txtsifreguncellememail.ForeColor = System.Drawing.Color.Red;
            this.txtsifreguncellememail.Location = new System.Drawing.Point(45, 54);
            this.txtsifreguncellememail.Multiline = true;
            this.txtsifreguncellememail.Name = "txtsifreguncellememail";
            this.txtsifreguncellememail.Size = new System.Drawing.Size(218, 58);
            this.txtsifreguncellememail.TabIndex = 10;
            this.txtsifreguncellememail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sifre_Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(308, 475);
            this.Controls.Add(this.txtsifreguncellememail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsifreguncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsifreguncelleyeni);
            this.Controls.Add(this.txtsifreguncelleeski);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sifre_Guncelle";
            this.Text = "Sifre_Guncelle";
            this.Load += new System.EventHandler(this.Sifre_Guncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsifreguncelleeski;
        private System.Windows.Forms.TextBox txtsifreguncelleyeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsifreguncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsifreguncellememail;
    }
}