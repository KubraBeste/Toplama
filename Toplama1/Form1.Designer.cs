namespace Toplama1
{
    partial class Form1
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
            this.btntoplama = new System.Windows.Forms.Button();
            this.lbnbirincisayi = new System.Windows.Forms.Label();
            this.lbnikincisayi = new System.Windows.Forms.Label();
            this.txtbirincisayi = new System.Windows.Forms.TextBox();
            this.txtikincisayi = new System.Windows.Forms.TextBox();
            this.tabgenel = new System.Windows.Forms.TabControl();
            this.tabtoplama = new System.Windows.Forms.TabPage();
            this.lbnsonuc = new System.Windows.Forms.Label();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.tabbildirim = new System.Windows.Forms.TabPage();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnileri = new System.Windows.Forms.Button();
            this.lvbildirim = new System.Windows.Forms.ListView();
            this.btntemizle = new System.Windows.Forms.Button();
            this.tabgenel.SuspendLayout();
            this.tabtoplama.SuspendLayout();
            this.tabbildirim.SuspendLayout();
            this.SuspendLayout();
            // 
            // btntoplama
            // 
            this.btntoplama.Location = new System.Drawing.Point(169, 105);
            this.btntoplama.Name = "btntoplama";
            this.btntoplama.Size = new System.Drawing.Size(144, 30);
            this.btntoplama.TabIndex = 2;
            this.btntoplama.Text = "Topla";
            this.btntoplama.UseVisualStyleBackColor = true;
            this.btntoplama.Click += new System.EventHandler(this.Btntoplama_Click);
            // 
            // lbnbirincisayi
            // 
            this.lbnbirincisayi.AutoSize = true;
            this.lbnbirincisayi.Location = new System.Drawing.Point(92, 7);
            this.lbnbirincisayi.Name = "lbnbirincisayi";
            this.lbnbirincisayi.Size = new System.Drawing.Size(77, 17);
            this.lbnbirincisayi.TabIndex = 1;
            this.lbnbirincisayi.Text = "Birinci Sayı";
            // 
            // lbnikincisayi
            // 
            this.lbnikincisayi.AutoSize = true;
            this.lbnikincisayi.Location = new System.Drawing.Point(92, 49);
            this.lbnikincisayi.Name = "lbnikincisayi";
            this.lbnikincisayi.Size = new System.Drawing.Size(70, 17);
            this.lbnikincisayi.TabIndex = 2;
            this.lbnikincisayi.Text = "İkinci Sayı";
            // 
            // txtbirincisayi
            // 
            this.txtbirincisayi.Location = new System.Drawing.Point(213, 7);
            this.txtbirincisayi.Name = "txtbirincisayi";
            this.txtbirincisayi.Size = new System.Drawing.Size(100, 22);
            this.txtbirincisayi.TabIndex = 0;
            this.txtbirincisayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtbirincisayi_KeyPress);
            // 
            // txtikincisayi
            // 
            this.txtikincisayi.Location = new System.Drawing.Point(213, 49);
            this.txtikincisayi.Name = "txtikincisayi";
            this.txtikincisayi.Size = new System.Drawing.Size(100, 22);
            this.txtikincisayi.TabIndex = 1;
            this.txtikincisayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtikincisayi_KeyPress);
            // 
            // tabgenel
            // 
            this.tabgenel.Controls.Add(this.tabtoplama);
            this.tabgenel.Controls.Add(this.tabbildirim);
            this.tabgenel.Location = new System.Drawing.Point(3, 2);
            this.tabgenel.Name = "tabgenel";
            this.tabgenel.SelectedIndex = 0;
            this.tabgenel.Size = new System.Drawing.Size(477, 292);
            this.tabgenel.TabIndex = 5;
            // 
            // tabtoplama
            // 
            this.tabtoplama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabtoplama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabtoplama.Controls.Add(this.btnileri);
            this.tabtoplama.Controls.Add(this.lbnsonuc);
            this.tabtoplama.Controls.Add(this.txtsonuc);
            this.tabtoplama.Controls.Add(this.btntoplama);
            this.tabtoplama.Controls.Add(this.txtikincisayi);
            this.tabtoplama.Controls.Add(this.lbnbirincisayi);
            this.tabtoplama.Controls.Add(this.txtbirincisayi);
            this.tabtoplama.Controls.Add(this.lbnikincisayi);
            this.tabtoplama.Location = new System.Drawing.Point(4, 25);
            this.tabtoplama.Name = "tabtoplama";
            this.tabtoplama.Padding = new System.Windows.Forms.Padding(3);
            this.tabtoplama.Size = new System.Drawing.Size(469, 263);
            this.tabtoplama.TabIndex = 0;
            this.tabtoplama.Text = "Toplama";
            // 
            // lbnsonuc
            // 
            this.lbnsonuc.AutoSize = true;
            this.lbnsonuc.Location = new System.Drawing.Point(92, 162);
            this.lbnsonuc.Name = "lbnsonuc";
            this.lbnsonuc.Size = new System.Drawing.Size(48, 17);
            this.lbnsonuc.TabIndex = 6;
            this.lbnsonuc.Text = "Sonuç";
            // 
            // txtsonuc
            // 
            this.txtsonuc.Location = new System.Drawing.Point(213, 159);
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.Size = new System.Drawing.Size(100, 22);
            this.txtsonuc.TabIndex = 3;
            // 
            // tabbildirim
            // 
            this.tabbildirim.BackColor = System.Drawing.Color.MistyRose;
            this.tabbildirim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabbildirim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabbildirim.Controls.Add(this.btntemizle);
            this.tabbildirim.Controls.Add(this.lvbildirim);
            this.tabbildirim.Controls.Add(this.btngeri);
            this.tabbildirim.Location = new System.Drawing.Point(4, 25);
            this.tabbildirim.Name = "tabbildirim";
            this.tabbildirim.Padding = new System.Windows.Forms.Padding(3);
            this.tabbildirim.Size = new System.Drawing.Size(469, 263);
            this.tabbildirim.TabIndex = 1;
            this.tabbildirim.Text = "Bildirim";
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(50, 223);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(118, 30);
            this.btngeri.TabIndex = 0;
            this.btngeri.Text = "<Geri";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.Btngeri_Click);
            // 
            // btnileri
            // 
            this.btnileri.Location = new System.Drawing.Point(169, 202);
            this.btnileri.Name = "btnileri";
            this.btnileri.Size = new System.Drawing.Size(144, 30);
            this.btnileri.TabIndex = 7;
            this.btnileri.Text = "İleri>";
            this.btnileri.UseVisualStyleBackColor = true;
            this.btnileri.Click += new System.EventHandler(this.Btnileri_Click);
            // 
            // lvbildirim
            // 
            this.lvbildirim.HideSelection = false;
            this.lvbildirim.Location = new System.Drawing.Point(16, 16);
            this.lvbildirim.Name = "lvbildirim";
            this.lvbildirim.Size = new System.Drawing.Size(411, 201);
            this.lvbildirim.TabIndex = 1;
            this.lvbildirim.UseCompatibleStateImageBehavior = false;
            this.lvbildirim.View = System.Windows.Forms.View.List;
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(218, 223);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(122, 30);
            this.btntemizle.TabIndex = 2;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.Btntemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 295);
            this.Controls.Add(this.tabgenel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabgenel.ResumeLayout(false);
            this.tabtoplama.ResumeLayout(false);
            this.tabtoplama.PerformLayout();
            this.tabbildirim.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntoplama;
        private System.Windows.Forms.Label lbnbirincisayi;
        private System.Windows.Forms.Label lbnikincisayi;
        private System.Windows.Forms.TextBox txtbirincisayi;
        private System.Windows.Forms.TextBox txtikincisayi;
        private System.Windows.Forms.TabControl tabgenel;
        private System.Windows.Forms.TabPage tabtoplama;
        private System.Windows.Forms.TabPage tabbildirim;
        private System.Windows.Forms.Label lbnsonuc;
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnileri;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.ListView lvbildirim;
    }
}

