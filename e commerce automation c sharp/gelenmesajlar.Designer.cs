namespace eticaret_programi
{
    partial class gelenmesajlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gelenmesajlar));
            this.gelenmesajgoster = new System.Windows.Forms.Button();
            this.txtgelenmesaj = new System.Windows.Forms.TextBox();
            this.gelenmesajsil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mesajgonderen = new System.Windows.Forms.DataGridView();
            this.txtmid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mesajgonderen)).BeginInit();
            this.SuspendLayout();
            // 
            // gelenmesajgoster
            // 
            this.gelenmesajgoster.BackColor = System.Drawing.Color.White;
            this.gelenmesajgoster.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.gelenmesajgoster.ForeColor = System.Drawing.Color.Red;
            this.gelenmesajgoster.Location = new System.Drawing.Point(328, 304);
            this.gelenmesajgoster.Name = "gelenmesajgoster";
            this.gelenmesajgoster.Size = new System.Drawing.Size(184, 70);
            this.gelenmesajgoster.TabIndex = 0;
            this.gelenmesajgoster.Text = "Göster";
            this.gelenmesajgoster.UseVisualStyleBackColor = false;
            this.gelenmesajgoster.Click += new System.EventHandler(this.gelenmesajgoster_Click);
            // 
            // txtgelenmesaj
            // 
            this.txtgelenmesaj.Font = new System.Drawing.Font("Hobo Std", 15F, System.Drawing.FontStyle.Bold);
            this.txtgelenmesaj.ForeColor = System.Drawing.Color.Red;
            this.txtgelenmesaj.Location = new System.Drawing.Point(328, 75);
            this.txtgelenmesaj.Multiline = true;
            this.txtgelenmesaj.Name = "txtgelenmesaj";
            this.txtgelenmesaj.ReadOnly = true;
            this.txtgelenmesaj.Size = new System.Drawing.Size(419, 202);
            this.txtgelenmesaj.TabIndex = 1;
            this.txtgelenmesaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center; 
            // 
            // gelenmesajsil
            // 
            this.gelenmesajsil.BackColor = System.Drawing.Color.White;
            this.gelenmesajsil.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.gelenmesajsil.ForeColor = System.Drawing.Color.Red;
            this.gelenmesajsil.Location = new System.Drawing.Point(563, 304);
            this.gelenmesajsil.Name = "gelenmesajsil";
            this.gelenmesajsil.Size = new System.Drawing.Size(184, 70);
            this.gelenmesajsil.TabIndex = 3;
            this.gelenmesajsil.Text = "Sil";
            this.gelenmesajsil.UseVisualStyleBackColor = false;
            this.gelenmesajsil.Click += new System.EventHandler(this.gelenmesajsil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gönderen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(478, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mesajı";
            // 
            // mesajgonderen
            // 
            this.mesajgonderen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mesajgonderen.Location = new System.Drawing.Point(24, 75);
            this.mesajgonderen.Name = "mesajgonderen";
            this.mesajgonderen.RowHeadersWidth = 51;
            this.mesajgonderen.RowTemplate.Height = 24;
            this.mesajgonderen.Size = new System.Drawing.Size(262, 299);
            this.mesajgonderen.TabIndex = 6;
            // 
            // txtmid
            // 
            this.txtmid.BackColor = System.Drawing.Color.White;
            this.txtmid.Font = new System.Drawing.Font("Hobo Std", 15F, System.Drawing.FontStyle.Bold);
            this.txtmid.ForeColor = System.Drawing.Color.Red;
            this.txtmid.Location = new System.Drawing.Point(82, 380);
            this.txtmid.Multiline = true;
            this.txtmid.Name = "txtmid";
            this.txtmid.ReadOnly = true;
            this.txtmid.Size = new System.Drawing.Size(148, 42);
            this.txtmid.TabIndex = 7;
            this.txtmid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gelenmesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtmid);
            this.Controls.Add(this.mesajgonderen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gelenmesajsil);
            this.Controls.Add(this.txtgelenmesaj);
            this.Controls.Add(this.gelenmesajgoster);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gelenmesajlar";
            this.Text = "gelenmesajlar";
            this.Load += new System.EventHandler(this.gelenmesajlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mesajgonderen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gelenmesajgoster;
        private System.Windows.Forms.TextBox txtgelenmesaj;
        private System.Windows.Forms.Button gelenmesajsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView mesajgonderen;
        private System.Windows.Forms.TextBox txtmid;
    }
}