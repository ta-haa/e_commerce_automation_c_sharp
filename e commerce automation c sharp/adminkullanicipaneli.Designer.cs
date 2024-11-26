namespace eticaret_programi
{
    partial class adminkullanicipaneli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminkullanicipaneli));
            this.admingoster = new System.Windows.Forms.Button();
            this.txtadminara = new System.Windows.Forms.TextBox();
            this.btnadminsil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // admingoster
            // 
            this.admingoster.BackColor = System.Drawing.Color.White;
            this.admingoster.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.admingoster.ForeColor = System.Drawing.Color.Red;
            this.admingoster.Location = new System.Drawing.Point(548, 647);
            this.admingoster.Name = "admingoster";
            this.admingoster.Size = new System.Drawing.Size(230, 78);
            this.admingoster.TabIndex = 6;
            this.admingoster.Text = "Göster";
            this.admingoster.UseVisualStyleBackColor = false;
            this.admingoster.Click += new System.EventHandler(this.admingoster_Click);
            // 
            // txtadminara
            // 
            this.txtadminara.Font = new System.Drawing.Font("Hobo Std", 15F, System.Drawing.FontStyle.Bold);
            this.txtadminara.ForeColor = System.Drawing.Color.Red;
            this.txtadminara.Location = new System.Drawing.Point(139, 39);
            this.txtadminara.Multiline = true;
            this.txtadminara.Name = "txtadminara";
            this.txtadminara.Size = new System.Drawing.Size(639, 77);
            this.txtadminara.TabIndex = 7;
            // 
            // btnadminsil
            // 
            this.btnadminsil.BackColor = System.Drawing.Color.White;
            this.btnadminsil.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.btnadminsil.ForeColor = System.Drawing.Color.Red;
            this.btnadminsil.Location = new System.Drawing.Point(803, 647);
            this.btnadminsil.Name = "btnadminsil";
            this.btnadminsil.Size = new System.Drawing.Size(230, 78);
            this.btnadminsil.TabIndex = 9;
            this.btnadminsil.Text = "Sil";
            this.btnadminsil.UseVisualStyleBackColor = false;
            this.btnadminsil.Click += new System.EventHandler(this.btnadminsil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Hobo Std", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(139, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(894, 439);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.White;
            this.btnara.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.btnara.ForeColor = System.Drawing.Color.Red;
            this.btnara.Location = new System.Drawing.Point(803, 39);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(230, 78);
            this.btnara.TabIndex = 11;
            this.btnara.Text = "Göster";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // adminkullanicipaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1093, 791);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnadminsil);
            this.Controls.Add(this.txtadminara);
            this.Controls.Add(this.admingoster);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminkullanicipaneli";
            this.Text = "adminkullanicipaneli";
            this.Load += new System.EventHandler(this.adminkullanicipaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admingoster;
        private System.Windows.Forms.TextBox txtadminara;
        private System.Windows.Forms.Button btnadminsil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnara;
    }
}