﻿/*
 * Created by SharpDevelop.
 * User: Diki Taufik Gurohman
 * Date: 01/04/2021
 * Time: 6:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AForge.Imaging;
//tambahkan library dari file yang sudah diinput pada reference
using AForge.Imaging.Filters;

namespace Diki_Taufik_Gurohman_E32190192_2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//membuat variable gambar dan gambar2
		private System.Drawing.Bitmap gambar;
		private System.Drawing.Bitmap gambar2;
		
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
		
		void Button1Click(object sender, EventArgs e)
		{
			//menginisiasi class OpenFileDialog() pada objek openFileDialog
			//membuka window untuk memilih file gambar dengan format yang sudah ditentukan
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files(*.PNG;*.BMP;*.JPG;*.JPEG;*.GIF)|*.PNG;*.BMP;*.JPG;" +
				"*.JPEG;*.GIF|All files (*.*)|*.*";
			//jika objek open file dialog = OK maka simpan gambar pada variable gambar 
			// lalu tampilkan pada pictureBox1 dengan menginisiasi varible gambar pada pictureBox1.image
			if (openFileDialog.ShowDialog ()== DialogResult.OK){
				gambar = (Bitmap) Bitmap.FromFile(openFileDialog.FileName);
				pictureBox1.Image = gambar;
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//jika gambar kosong/null maka akan mengembalikan nilai kosong/null
			if (gambar2==null) return;
			//menginisiasi class SaveFileDialog() pada objek saveFileDialog 
			//dari hasil morfologi yang sudah disimpan(clone dari gambar) pada variable gambar2
			//gambar akan disave dengan format yang sudah ditentukan
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			//membuka window untuk save file
			saveFileDialog.Filter = "Png Image (.png)|*.png|Bitmap Image (.bmp)|"+
				"*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpg)|*.jpg";
			//jika save file = OK lalu gambar2 akan disave sesuai dengan nama yang sudah dimasukkan
			if (saveFileDialog.ShowDialog ()== DialogResult.OK){
				gambar2.Save(saveFileDialog.FileName);
			}
		}
		
		void ErosiToolStripMenuItemClick(object sender, EventArgs e)
		{
			//jika gambar kosong/null maka akan mengembalikan nilai kosong/null
			if (gambar==null) return;
			//membuat filter dari inisiasi class Erosio() pada objek erosion 
			Erosion erosion = new Erosion( );
			//clone variable gambar pada variable gambar2
			gambar2 = (Bitmap) gambar.Clone();
			//aplikasikan filter objek erosion pada gambar2
			erosion.ApplyInPlace(gambar2);
			//tampilkan hasil gambar2 yang sudah diaplikasikan filter pada pictureBox2
			pictureBox2.Image = gambar2;
		}
		
		void DilasiToolStripMenuItemClick(object sender, EventArgs e)
		{
			//jika gambar kosong/null maka akan mengembalikan nilai kosong/null
			if (gambar==null) return;
			//membuat filter dari inisiasi class Dilatation() pada objek dilatation
			Dilatation dilatation = new Dilatation( );
			//clone variable gambar pada variable gambar2
			gambar2 = (Bitmap) gambar.Clone();
			//aplikasikan filter objek dilatation pada gambar2
			dilatation.ApplyInPlace(gambar2);
			//tampilkan hasil gambar2 yang sudah diaplikasikan filter pada pictureBox2
			pictureBox2.Image = gambar2;
		}
		
		void OpeningToolStripMenuItemClick(object sender, EventArgs e)
		{
			//jika gambar kosong/null maka akan mengembalikan nilai kosong/null
			if (gambar==null) return;
			//membuat filter dari inisiasi class Opening() pada objek opening
			Opening opening = new Opening( );
			//clone variable gambar pada variable gambar2
			gambar2 = (Bitmap) gambar.Clone();
			//aplikasikan filter objek opening pada gambar2
			opening.ApplyInPlace(gambar2);
			//tampilkan hasil gambar2 yang sudah diaplikasikan filter pada pictureBox2
			pictureBox2.Image = gambar2;
		}
		
		void ClosingToolStripMenuItemClick(object sender, EventArgs e)
		{
			//jika gambar kosong/null maka akan mengembalikan nilai kosong/null
			if (gambar==null) return;
			//membuat filter dari inisiasi class Closing() pada objek closing
			Closing closing = new Closing( );
			//clone variable gambar pada variable gambar2
			gambar2 = (Bitmap) gambar.Clone();
			//aplikasikan filter objek closing pada gambar2
			closing.ApplyInPlace(gambar2);
			//tampilkan hasil gambar2 yang sudah diaplikasikan filter pada pictureBox2
			pictureBox2.Image = gambar2;
		}
	}
}
