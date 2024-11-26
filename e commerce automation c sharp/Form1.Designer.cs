namespace eticaret_programi
{
    partial class giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.btnadmingiris = new System.Windows.Forms.Button();
            this.btnuyegiris = new System.Windows.Forms.Button();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.txtuyeolsifre = new System.Windows.Forms.TextBox();
            this.txtuyeolmail = new System.Windows.Forms.TextBox();
            this.txtuyeolsoyad = new System.Windows.Forms.TextBox();
            this.txtuyeolad = new System.Windows.Forms.TextBox();
            this.btnuyeol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblzaman = new System.Windows.Forms.Label();
            this.txtuyeolcaptcha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuyeoltelefon = new System.Windows.Forms.TextBox();
            this.zaman = new System.Windows.Forms.Timer(this.components);
            this.lblcapctha = new System.Windows.Forms.Label();
            this.btnqr = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.formac = new System.Windows.Forms.ToolStripMenuItem();
            this.formgizle = new System.Windows.Forms.ToolStripMenuItem();
            this.formkapat = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnadmingiris
            // 
            this.btnadmingiris.BackColor = System.Drawing.Color.Red;
            this.btnadmingiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadmingiris.Font = new System.Drawing.Font("Hobo Std", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmingiris.ForeColor = System.Drawing.Color.Transparent;
            this.btnadmingiris.Image = ((System.Drawing.Image)(resources.GetObject("btnadmingiris.Image")));
            this.btnadmingiris.Location = new System.Drawing.Point(686, 329);
            this.btnadmingiris.Name = "btnadmingiris";
            this.btnadmingiris.Size = new System.Drawing.Size(432, 290);
            this.btnadmingiris.TabIndex = 41;
            this.btnadmingiris.Text = "Admin Girişi";
            this.btnadmingiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnadmingiris, "Admin Girişi");
            this.btnadmingiris.UseVisualStyleBackColor = false;
            this.btnadmingiris.Click += new System.EventHandler(this.btnadmingiris_Click);
            // 
            // btnuyegiris
            // 
            this.btnuyegiris.BackColor = System.Drawing.Color.Red;
            this.btnuyegiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnuyegiris.Font = new System.Drawing.Font("Hobo Std", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuyegiris.ForeColor = System.Drawing.Color.Transparent;
            this.btnuyegiris.Image = ((System.Drawing.Image)(resources.GetObject("btnuyegiris.Image")));
            this.btnuyegiris.Location = new System.Drawing.Point(686, 14);
            this.btnuyegiris.Name = "btnuyegiris";
            this.btnuyegiris.Size = new System.Drawing.Size(432, 295);
            this.btnuyegiris.TabIndex = 40;
            this.btnuyegiris.Text = "Üye Girişi";
            this.btnuyegiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnuyegiris, "Admin Girişi");
            this.btnuyegiris.UseVisualStyleBackColor = false;
            this.btnuyegiris.Click += new System.EventHandler(this.btnuyegiris_Click);
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.BackColor = System.Drawing.Color.Red;
            this.lblsifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblsifre.Font = new System.Drawing.Font("Hobo Std", 25.8F, System.Drawing.FontStyle.Bold);
            this.lblsifre.ForeColor = System.Drawing.Color.Transparent;
            this.lblsifre.Location = new System.Drawing.Point(314, 473);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(129, 61);
            this.lblsifre.TabIndex = 39;
            this.lblsifre.Text = "Sifre";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.BackColor = System.Drawing.Color.Red;
            this.lblsoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblsoyad.Font = new System.Drawing.Font("Hobo Std", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoyad.ForeColor = System.Drawing.Color.Transparent;
            this.lblsoyad.Location = new System.Drawing.Point(304, 162);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(152, 61);
            this.lblsoyad.TabIndex = 37;
            this.lblsoyad.Text = "Soyad";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.BackColor = System.Drawing.Color.Red;
            this.lblad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblad.Font = new System.Drawing.Font("Hobo Std", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblad.ForeColor = System.Drawing.Color.Transparent;
            this.lblad.Location = new System.Drawing.Point(328, 14);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(90, 67);
            this.lblad.TabIndex = 36;
            this.lblad.Text = "Ad";
            // 
            // txtuyeolsifre
            // 
            this.txtuyeolsifre.Font = new System.Drawing.Font("Hobo Std", 15F, System.Drawing.FontStyle.Bold);
            this.txtuyeolsifre.ForeColor = System.Drawing.Color.Red;
            this.txtuyeolsifre.Location = new System.Drawing.Point(227, 537);
            this.txtuyeolsifre.MaxLength = 50;
            this.txtuyeolsifre.Multiline = true;
            this.txtuyeolsifre.Name = "txtuyeolsifre";
            this.txtuyeolsifre.Size = new System.Drawing.Size(293, 65);
            this.txtuyeolsifre.TabIndex = 16;
            this.toolTip1.SetToolTip(this.txtuyeolsifre, "Şifreniz");
            this.txtuyeolsifre.TextChanged += new System.EventHandler(this.txtuyeolsifre_TextChanged);
            // 
            // txtuyeolmail
            // 
            this.txtuyeolmail.Font = new System.Drawing.Font("Hobo Std", 15F, System.Drawing.FontStyle.Bold);
            this.txtuyeolmail.ForeColor = System.Drawing.Color.Red;
            this.txtuyeolmail.Location = new System.Drawing.Point(227, 376);
            this.txtuyeolmail.MaxLength = 50;
            this.txtuyeolmail.Multiline = true;
            this.txtuyeolmail.Name = "txtuyeolmail";
            this.txtuyeolmail.Size = new System.Drawing.Size(293, 76);
            this.txtuyeolmail.TabIndex = 34;
            this.toolTip1.SetToolTip(this.txtuyeolmail, "Epostanız");
            // 
            // txtuyeolsoyad
            // 
            this.txtuyeolsoyad.Font = new System.Drawing.Font("Hobo Std", 15F, System.Drawing.FontStyle.Bold);
            this.txtuyeolsoyad.ForeColor = System.Drawing.Color.Red;
            this.txtuyeolsoyad.Location = new System.Drawing.Point(227, 233);
            this.txtuyeolsoyad.MaxLength = 50;
            this.txtuyeolsoyad.Multiline = true;
            this.txtuyeolsoyad.Name = "txtuyeolsoyad";
            this.txtuyeolsoyad.Size = new System.Drawing.Size(293, 76);
            this.txtuyeolsoyad.TabIndex = 34;
            this.toolTip1.SetToolTip(this.txtuyeolsoyad, "Soyadınız");
            this.txtuyeolsoyad.TextChanged += new System.EventHandler(this.txtuyeolsoyad_TextChanged);
            // 
            // txtuyeolad
            // 
            this.txtuyeolad.Font = new System.Drawing.Font("Hobo Std", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuyeolad.ForeColor = System.Drawing.Color.Red;
            this.txtuyeolad.Location = new System.Drawing.Point(227, 83);
            this.txtuyeolad.MaxLength = 50;
            this.txtuyeolad.Multiline = true;
            this.txtuyeolad.Name = "txtuyeolad";
            this.txtuyeolad.Size = new System.Drawing.Size(293, 76);
            this.txtuyeolad.TabIndex = 34;
            this.txtuyeolad.Tag = "";
            this.toolTip1.SetToolTip(this.txtuyeolad, "Adınız");
            this.txtuyeolad.TextChanged += new System.EventHandler(this.txtuyeolad_TextChanged);
            // 
            // btnuyeol
            // 
            this.btnuyeol.BackColor = System.Drawing.Color.Red;
            this.btnuyeol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnuyeol.Font = new System.Drawing.Font("Hobo Std", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuyeol.ForeColor = System.Drawing.Color.Transparent;
            this.btnuyeol.Location = new System.Drawing.Point(227, 955);
            this.btnuyeol.Name = "btnuyeol";
            this.btnuyeol.Size = new System.Drawing.Size(293, 82);
            this.btnuyeol.TabIndex = 30;
            this.btnuyeol.Text = "Kayıt Ol";
            this.btnuyeol.UseVisualStyleBackColor = false;
            this.btnuyeol.Click += new System.EventHandler(this.btnuyeol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(294, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 61);
            this.label1.TabIndex = 42;
            this.label1.Text = "Eposta";
            // 
            // lblzaman
            // 
            this.lblzaman.AutoSize = true;
            this.lblzaman.BackColor = System.Drawing.Color.Transparent;
            this.lblzaman.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblzaman.Font = new System.Drawing.Font("Hobo Std", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblzaman.ForeColor = System.Drawing.Color.Transparent;
            this.lblzaman.Location = new System.Drawing.Point(891, 786);
            this.lblzaman.Name = "lblzaman";
            this.lblzaman.Size = new System.Drawing.Size(0, 33);
            this.lblzaman.TabIndex = 44;
            // 
            // txtuyeolcaptcha
            // 
            this.txtuyeolcaptcha.Font = new System.Drawing.Font("Hobo Std", 15F, System.Drawing.FontStyle.Bold);
            this.txtuyeolcaptcha.ForeColor = System.Drawing.Color.Red;
            this.txtuyeolcaptcha.Location = new System.Drawing.Point(227, 841);
            this.txtuyeolcaptcha.MaxLength = 4;
            this.txtuyeolcaptcha.Multiline = true;
            this.txtuyeolcaptcha.Name = "txtuyeolcaptcha";
            this.txtuyeolcaptcha.Size = new System.Drawing.Size(293, 65);
            this.txtuyeolcaptcha.TabIndex = 43;
            this.toolTip1.SetToolTip(this.txtuyeolcaptcha, "Güvenlik Şifresi");
            this.txtuyeolcaptcha.TextChanged += new System.EventHandler(this.txtuyeolcaptcha_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Hobo Std", 25.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(294, 620);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 61);
            this.label3.TabIndex = 46;
            this.label3.Text = "Telefon";
            // 
            // txtuyeoltelefon
            // 
            this.txtuyeoltelefon.Font = new System.Drawing.Font("Hobo Std", 15F, System.Drawing.FontStyle.Bold);
            this.txtuyeoltelefon.ForeColor = System.Drawing.Color.Red;
            this.txtuyeoltelefon.Location = new System.Drawing.Point(227, 684);
            this.txtuyeoltelefon.MaxLength = 11;
            this.txtuyeoltelefon.Multiline = true;
            this.txtuyeoltelefon.Name = "txtuyeoltelefon";
            this.txtuyeoltelefon.Size = new System.Drawing.Size(293, 65);
            this.txtuyeoltelefon.TabIndex = 45;
            this.toolTip1.SetToolTip(this.txtuyeoltelefon, "Telefon Numaranız");
            this.txtuyeoltelefon.TextChanged += new System.EventHandler(this.txtuyeoltelefon_TextChanged);
            // 
            // zaman
            // 
            this.zaman.Tick += new System.EventHandler(this.zaman_Tick);
            // 
            // lblcapctha
            // 
            this.lblcapctha.AutoSize = true;
            this.lblcapctha.BackColor = System.Drawing.Color.Red;
            this.lblcapctha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblcapctha.Font = new System.Drawing.Font("Hobo Std", 25.8F, System.Drawing.FontStyle.Bold);
            this.lblcapctha.ForeColor = System.Drawing.Color.Transparent;
            this.lblcapctha.Location = new System.Drawing.Point(315, 766);
            this.lblcapctha.Name = "lblcapctha";
            this.lblcapctha.Size = new System.Drawing.Size(0, 61);
            this.lblcapctha.TabIndex = 47;
            // 
            // btnqr
            // 
            this.btnqr.BackColor = System.Drawing.Color.Red;
            this.btnqr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnqr.Font = new System.Drawing.Font("Hobo Std", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqr.ForeColor = System.Drawing.Color.Transparent;
            this.btnqr.Image = ((System.Drawing.Image)(resources.GetObject("btnqr.Image")));
            this.btnqr.Location = new System.Drawing.Point(686, 632);
            this.btnqr.Name = "btnqr";
            this.btnqr.Size = new System.Drawing.Size(432, 411);
            this.btnqr.TabIndex = 48;
            this.toolTip1.SetToolTip(this.btnqr, "Okut");
            this.btnqr.UseVisualStyleBackColor = false;
            this.btnqr.Click += new System.EventHandler(this.btnqr_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(77, 28);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iletişimToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contextMenuStrip1.BackgroundImage")));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formac,
            this.formgizle,
            this.formkapat});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 76);
            // 
            // formac
            // 
            this.formac.Name = "formac";
            this.formac.Size = new System.Drawing.Size(163, 24);
            this.formac.Text = "Formu Aç";
            this.formac.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // formgizle
            // 
            this.formgizle.Name = "formgizle";
            this.formgizle.Size = new System.Drawing.Size(163, 24);
            this.formgizle.Text = "Formu Gizle";
            this.formgizle.Click += new System.EventHandler(this.formuKapatToolStripMenuItem_Click);
            // 
            // formkapat
            // 
            this.formkapat.Name = "formkapat";
            this.formkapat.Size = new System.Drawing.Size(163, 24);
            this.formkapat.Text = "Formu Kapat";
            this.formkapat.Click += new System.EventHandler(this.formuKapatToolStripMenuItem1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 1055);
            this.Controls.Add(this.lblzaman);
            this.Controls.Add(this.btnqr);
            this.Controls.Add(this.lblcapctha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtuyeoltelefon);
            this.Controls.Add(this.txtuyeolcaptcha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadmingiris);
            this.Controls.Add(this.btnuyegiris);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.txtuyeolsifre);
            this.Controls.Add(this.txtuyeolmail);
            this.Controls.Add(this.txtuyeolsoyad);
            this.Controls.Add(this.txtuyeolad);
            this.Controls.Add(this.btnuyeol);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş_Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.giris_FormClosed);
            this.Load += new System.EventHandler(this.giris_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadmingiris;
        private System.Windows.Forms.Button btnuyegiris;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.TextBox txtuyeolsifre;
        private System.Windows.Forms.TextBox txtuyeolmail;
        private System.Windows.Forms.TextBox txtuyeolsoyad;
        private System.Windows.Forms.TextBox txtuyeolad;
        private System.Windows.Forms.Button btnuyeol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblzaman;
        private System.Windows.Forms.TextBox txtuyeolcaptcha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtuyeoltelefon;
        private System.Windows.Forms.Timer zaman;
        private System.Windows.Forms.Label lblcapctha;
        private System.Windows.Forms.Button btnqr;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem formac;
        private System.Windows.Forms.ToolStripMenuItem formgizle;
        private System.Windows.Forms.ToolStripMenuItem formkapat;
    }
}

