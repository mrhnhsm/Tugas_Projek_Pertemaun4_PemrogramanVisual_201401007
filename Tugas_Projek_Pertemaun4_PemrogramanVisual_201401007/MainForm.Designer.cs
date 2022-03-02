/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 02/03/2022
 * Time: 15:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugas_Projek_Pertemaun4_PemrogramanVisual_201401007
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.Button klik;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox nim;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox kelas;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox matakuliah;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nama = new System.Windows.Forms.TextBox();
			this.klik = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.nim = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.kelas = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.matakuliah = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nama  :";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Minion Pro Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(505, 40);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tugas Pertemuan 4 Pemrograman Visual";
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(106, 88);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(345, 26);
			this.nama.TabIndex = 2;
			// 
			// klik
			// 
			this.klik.Location = new System.Drawing.Point(172, 283);
			this.klik.Name = "klik";
			this.klik.Size = new System.Drawing.Size(143, 65);
			this.klik.TabIndex = 3;
			this.klik.Text = "Klik Saya";
			this.klik.UseVisualStyleBackColor = true;
			this.klik.Click += new System.EventHandler(this.KlikClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "NIM     :";
			// 
			// nim
			// 
			this.nim.Location = new System.Drawing.Point(106, 131);
			this.nim.Name = "nim";
			this.nim.Size = new System.Drawing.Size(345, 26);
			this.nim.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(32, 178);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Kelas   :";
			// 
			// kelas
			// 
			this.kelas.Location = new System.Drawing.Point(106, 178);
			this.kelas.Name = "kelas";
			this.kelas.Size = new System.Drawing.Size(345, 26);
			this.kelas.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(32, 224);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Matkul :";
			// 
			// matakuliah
			// 
			this.matakuliah.Location = new System.Drawing.Point(106, 224);
			this.matakuliah.Name = "matakuliah";
			this.matakuliah.Size = new System.Drawing.Size(345, 26);
			this.matakuliah.TabIndex = 9;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 386);
			this.Controls.Add(this.matakuliah);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.kelas);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nim);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.klik);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Tugas_Projek_Pertemaun4_PemrogramanVisual_201401007";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
