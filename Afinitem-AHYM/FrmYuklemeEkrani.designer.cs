﻿namespace Sunum
{
	partial class FrmYuklemeEkrani
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYuklemeEkrani));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1000, 100);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(114, 86);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.DarkGray;
			this.label1.Location = new System.Drawing.Point(141, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(254, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Afinitem Sağlık hizmeti";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 102);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(452, 396);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
			this.label2.Location = new System.Drawing.Point(480, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(309, 63);
			this.label2.TabIndex = 3;
			this.label2.Text = "Hoşgeldiniz";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblUsername.ForeColor = System.Drawing.Color.DarkGray;
			this.lblUsername.Location = new System.Drawing.Point(576, 210);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(124, 29);
			this.lblUsername.TabIndex = 4;
			this.lblUsername.Text = "Username";
			// 
			// timer1
			// 
			this.timer1.Interval = 30;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 30;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// circularProgressBar2
			// 
			this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
			this.circularProgressBar2.AnimationSpeed = 500;
			this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
			this.circularProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
			this.circularProgressBar2.ForeColor = System.Drawing.Color.Silver;
			this.circularProgressBar2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
			this.circularProgressBar2.InnerMargin = 2;
			this.circularProgressBar2.InnerWidth = -1;
			this.circularProgressBar2.Location = new System.Drawing.Point(513, 264);
			this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
			this.circularProgressBar2.Name = "circularProgressBar2";
			this.circularProgressBar2.OuterColor = System.Drawing.Color.Gray;
			this.circularProgressBar2.OuterMargin = -25;
			this.circularProgressBar2.OuterWidth = 26;
			this.circularProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
			this.circularProgressBar2.ProgressWidth = 25;
			this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.circularProgressBar2.Size = new System.Drawing.Size(150, 150);
			this.circularProgressBar2.StartAngle = 270;
			this.circularProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
			this.circularProgressBar2.SubscriptText = "";
			this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
			this.circularProgressBar2.SuperscriptText = "%";
			this.circularProgressBar2.TabIndex = 5;
			this.circularProgressBar2.Text = "0";
			this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.circularProgressBar2.Value = 68;
















			// 
			// FormWelcome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
			this.ClientSize = new System.Drawing.Size(1000, 500);
			this.Controls.Add(this.circularProgressBar2);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormWelcome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormWelcome";
			this.Load += new System.EventHandler(this.FormWelcome_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private CircularProgressBar.CircularProgressBar circularProgressBar1;
		private CircularProgressBar.CircularProgressBar circularProgressBar2;
	}
}