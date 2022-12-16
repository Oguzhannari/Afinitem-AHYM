namespace Aile_Hekimligi_Bilgi_Yonetim_Sistemi
{
	partial class FrmAnaSayfa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sira_no_kaldir = new Sunum.AfiControls.AfiButton();
            this.btn_hasta_giris_ekrani_getir = new Sunum.AfiControls.AfiButton();
            this.afiTextBox1 = new Sunum.AfiControls.AfiTextBox();
            this.btnYenile = new Sunum.AfiControls.AfiButton();
            this.btn_misafir_ekle = new Sunum.AfiControls.AfiButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1184, 457);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hasta T.C Giriniz:";
            // 
            // btn_sira_no_kaldir
            // 
            this.btn_sira_no_kaldir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_sira_no_kaldir.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_sira_no_kaldir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_sira_no_kaldir.BorderRadius = 40;
            this.btn_sira_no_kaldir.BorderSize = 0;
            this.btn_sira_no_kaldir.FlatAppearance.BorderSize = 0;
            this.btn_sira_no_kaldir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sira_no_kaldir.ForeColor = System.Drawing.Color.White;
            this.btn_sira_no_kaldir.Location = new System.Drawing.Point(1002, 39);
            this.btn_sira_no_kaldir.Name = "btn_sira_no_kaldir";
            this.btn_sira_no_kaldir.Size = new System.Drawing.Size(150, 40);
            this.btn_sira_no_kaldir.TabIndex = 6;
            this.btn_sira_no_kaldir.Text = "Sıra numaralarını Kaldır";
            this.btn_sira_no_kaldir.TextColor = System.Drawing.Color.White;
            this.btn_sira_no_kaldir.UseVisualStyleBackColor = false;
            this.btn_sira_no_kaldir.Click += new System.EventHandler(this.btn_sira_no_kaldir_Click);
            // 
            // btn_hasta_giris_ekrani_getir
            // 
            this.btn_hasta_giris_ekrani_getir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_hasta_giris_ekrani_getir.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_hasta_giris_ekrani_getir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_hasta_giris_ekrani_getir.BorderRadius = 40;
            this.btn_hasta_giris_ekrani_getir.BorderSize = 0;
            this.btn_hasta_giris_ekrani_getir.FlatAppearance.BorderSize = 0;
            this.btn_hasta_giris_ekrani_getir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hasta_giris_ekrani_getir.ForeColor = System.Drawing.Color.White;
            this.btn_hasta_giris_ekrani_getir.Location = new System.Drawing.Point(836, 39);
            this.btn_hasta_giris_ekrani_getir.Name = "btn_hasta_giris_ekrani_getir";
            this.btn_hasta_giris_ekrani_getir.Size = new System.Drawing.Size(150, 40);
            this.btn_hasta_giris_ekrani_getir.TabIndex = 5;
            this.btn_hasta_giris_ekrani_getir.Text = "Hasta Giriş Ekranı";
            this.btn_hasta_giris_ekrani_getir.TextColor = System.Drawing.Color.White;
            this.btn_hasta_giris_ekrani_getir.UseVisualStyleBackColor = false;
            this.btn_hasta_giris_ekrani_getir.Click += new System.EventHandler(this.btn_hasta_giris_ekrani_getir_Click);
            // 
            // afiTextBox1
            // 
            this.afiTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.afiTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.afiTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.afiTextBox1.BorderRadius = 0;
            this.afiTextBox1.BorderSize = 2;
            this.afiTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.afiTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.afiTextBox1.Location = new System.Drawing.Point(13, 48);
            this.afiTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.afiTextBox1.Multiline = false;
            this.afiTextBox1.Name = "afiTextBox1";
            this.afiTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.afiTextBox1.PasswordChar = false;
            this.afiTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.afiTextBox1.PlaceholderText = "";
            this.afiTextBox1.Size = new System.Drawing.Size(249, 31);
            this.afiTextBox1.TabIndex = 4;
            this.afiTextBox1.Texts = "";
            this.afiTextBox1.UnderlinedStyle = false;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnYenile.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnYenile.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnYenile.BorderRadius = 40;
            this.btnYenile.BorderSize = 0;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(671, 39);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(150, 40);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.TextColor = System.Drawing.Color.White;
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.afiButton1_Click);
            // 
            // btn_misafir_ekle
            // 
            this.btn_misafir_ekle.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_misafir_ekle.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_misafir_ekle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_misafir_ekle.BorderRadius = 40;
            this.btn_misafir_ekle.BorderSize = 0;
            this.btn_misafir_ekle.FlatAppearance.BorderSize = 0;
            this.btn_misafir_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_misafir_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_misafir_ekle.Location = new System.Drawing.Point(499, 39);
            this.btn_misafir_ekle.Name = "btn_misafir_ekle";
            this.btn_misafir_ekle.Size = new System.Drawing.Size(150, 40);
            this.btn_misafir_ekle.TabIndex = 8;
            this.btn_misafir_ekle.Text = "Misafir Ekle";
            this.btn_misafir_ekle.TextColor = System.Drawing.Color.White;
            this.btn_misafir_ekle.UseVisualStyleBackColor = false;
            this.btn_misafir_ekle.Click += new System.EventHandler(this.btn_misafir_ekle_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.btn_misafir_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sira_no_kaldir);
            this.Controls.Add(this.btn_hasta_giris_ekrani_getir);
            this.Controls.Add(this.afiTextBox1);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmAnaSayfa";
            this.Text = "FrmAnaSayfa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private Sunum.AfiControls.AfiTextBox afiTextBox1;
		private Sunum.AfiControls.AfiButton btnYenile;
		private Sunum.AfiControls.AfiButton btn_hasta_giris_ekrani_getir;
		private Sunum.AfiControls.AfiButton btn_sira_no_kaldir;
		private System.Windows.Forms.Label label1;
		private Sunum.AfiControls.AfiButton btn_misafir_ekle;
	}
}