/*
 * Created by SharpDevelop.
 * User: ACER
 * Date: 02/03/2022
 * Time: 15:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas_Projek_Pertemaun4_PemrogramanVisual_201401007
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void KlikClick(object sender, EventArgs e)
		{
			string name = nama.Text;
			int nomor = int.Parse(nim.Text);
			string kel = kelas.Text;
			string matkul = matakuliah.Text;
			
			MessageBox.Show ("Selamat Datang " + name + " Dengan NIM " + nomor + " Dikelas KOM " + kel + " Dengan Mata Kuliah " + matkul);
		}
	}
}
