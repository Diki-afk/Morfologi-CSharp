/*
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
		void BrightNessToolStripMenuItemClick(object sender, EventArgs e)
		{
			//jika gambar kosong/null maka akan mengembalikan nilai kosong/null
			if (gambar==null) return;
			//clone variable gambar ke variable gambar2 dan menginisiasi class Rectangle
			//dan menerapkan format pixel 24bppRgb
			gambar2 = gambar.Clone(new Rectangle(0,0,gambar.Width,gambar.Height),
			                       System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			//calculate maximum value pada gambar2
			AForge.Imaging.ImageStatistics stat = new AForge.Imaging.ImageStatistics( gambar2 );
			//menginisiasi varibale max
			int max = Math.Max(Math.Max(stat.Red.Max, stat.Green.Max), stat.Blue.Max);
			//membuat filter dari inisiasi class BrightnessCorrection() pada objek brightnessCorrection
			//dengan argumen 255-max
			BrightnessCorrection brightnessCorrection = new BrightnessCorrection(255-max);
			//menerapkan filter pada gambar2
			brightnessCorrection.ApplyInPlace(gambar2);
			pictureBox2.Image = gambar2;
		}
		void Brightness20ToolStripMenuItemClick(object sender, EventArgs e)
		{
			//jika gambar kosong/null maka akan mengembalikan nilai kosong/null
			if (gambar==null) return;
			//membuat filter dari inisiasi class BrightnessCorrection() dengan argumen 20 pada objek brignessCorrection
			BrightnessCorrection brignessCorrection = new BrightnessCorrection(20);
			//clone variable gambar pada variable gambar2
			gambar2 = (Bitmap) gambar.Clone();
			//aplikasikan filter objek brignessCorrection pada gambar2
			brignessCorrection.ApplyInPlace(gambar2);
			//tampilkan hasil gambar2 yang sudah diaplikasikan filter pada pictureBox2
			pictureBox2.Image = gambar2;
		}
		void ContrastCorrectionToolStripMenuItemClick(object sender, EventArgs e)
		{
			//jika gambar kosong/null maka akan mengembalikan nilai kosong/null
			if (gambar==null) return;
			//membuat filter dari inisiasi class ContrastCorrection() dengan argumen 25 pada objek contrastCorrection
			ContrastCorrection contrastCorrection = new ContrastCorrection(25);
			//clone variable gambar pada variable gambar2
			gambar2 = (Bitmap) gambar.Clone();
			//aplikasikan filter objek contrastCorrection pada gambar2
			contrastCorrection.ApplyInPlace(gambar2);
			//tampilkan hasil gambar2 yang sudah diaplikasikan filter pada pictureBox2
			pictureBox2.Image = gambar2;
		}
		void SepiaToolStripMenuItemClick(object sender, EventArgs e)
		{
			//jika gambar kosong/null maka akan mengembalikan nilai kosong/null
			if (gambar==null) return;
			//membuat filter dari inisiasi class Sepia() pada objek sepia
			Sepia sepia = new Sepia( );
			//clone variable gambar pada variable gambar2
			gambar2 = (Bitmap) gambar.Clone();
			//aplikasikan filter objek sepia pada gambar2
			sepia.ApplyInPlace(gambar2);
			//tampilkan hasil gambar2 yang sudah diaplikasikan filter pada pictureBox2
			pictureBox2.Image = gambar2;
		}
		void BlurToolStripMenuItemClick(object sender, EventArgs e)
		{
			//jika gambar kosong/null maka akan mengembalikan nilai kosong/null
			if (gambar==null) return;
			//membuat filter dari inisiasi class Blur() pada objek blur
			Blur blur = new Blur( );
			//clone variable gambar pada variable gambar2
			gambar2 = (Bitmap) gambar.Clone();
			//aplikasikan filter objek blur pada gambar2
			blur.ApplyInPlace(gambar2);
			//tampilkan hasil gambar2 yang sudah diaplikasikan filter pada pictureBox2
			pictureBox2.Image = gambar2;
		}
		void SharpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			//jika gambar kosong/null maka akan mengembalikan nilai kosong/null
			if (gambar==null) return;
			//membuat filter dari inisiasi class Sharpen() pada objek sharpen
			Sharpen sharpen = new Sharpen( );
			//clone variable gambar pada variable gambar2
			gambar2 = (Bitmap) gambar.Clone();
			//aplikasikan filter objek sharpen pada gambar2
			sharpen.ApplyInPlace(gambar2);
			//tampilkan hasil gambar2 yang sudah diaplikasikan filter pada pictureBox2
			pictureBox2.Image = gambar2;
		}
		void GrayscaleToolStripMenuItemClick(object sender, EventArgs e)
		{
			//jika gambar kosong/null maka akan mengembalikan nilai kosong/null
			if (gambar==null) return;
			//membuat filter dari inisiasi class Grayscale() dengan 3 argumen pada objek grayscale
			Grayscale grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
			//aplikasikan filter objek grayscale pada gambar lalu diinisiasi ke gambar2
			gambar2 = grayscale.Apply(gambar);
			//tampilkan hasil gambar2 yang sudah diaplikasikan filter pada pictureBox2
			pictureBox2.Image = gambar2;
		}
		void InvertToolStripMenuItemClick(object sender, EventArgs e)
		{
			//jika gambar kosong/null maka akan mengembalikan nilai kosong/null
			if (gambar==null) return;
			//membuat filter dari inisiasi class Invert() pada objek invert
			Invert invert = new Invert( );
			//clone variable gambar pada variable gambar2
			gambar2 = (Bitmap) gambar.Clone();
			//aplikasikan filter objek invert pada gambar2
			invert.ApplyInPlace(gambar2);
			//tampilkan hasil gambar2 yang sudah diaplikasikan filter pada pictureBox2
			pictureBox2.Image = gambar2;
		}
		void ThresholdingToolStripMenuItemClick(object sender, EventArgs e)
		{
			//jika gambar kosong/null maka akan mengembalikan nilai kosong/null
			if (gambar==null) return;
			//clone variable gambar ke variable gambar2 dan menginisiasi class Rectangle
			//dan menerapkan format pixel 24bppRgb
			gambar2 = gambar.Clone(new Rectangle(0,0,gambar.Width,gambar.Height),
			                       System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			//convert ke grayscale terlebih dahulu lalu aplikasikan filter thresholding.
			//inisiasi filter grayscale disertai argumen
			Grayscale grayscaleF = new Grayscale(0.2125, 0.7154, 0.0721);
			gambar2 = grayscaleF.Apply(gambar2);
			//inisiasi filter thresholding
			OtsuThreshold otsuThreshold = new OtsuThreshold( );
			//aplikasikan filter pada gambar2
			otsuThreshold.ApplyInPlace( gambar2 );
			//tampilkan pada picturebox2
			pictureBox2.Image = gambar2;
		}
	}
}
