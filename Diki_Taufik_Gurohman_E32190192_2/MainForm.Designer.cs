﻿/*
 * Created by SharpDevelop.
 * User: lenovo
 * Date: 01/04/2021
 * Time: 6:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Diki_Taufik_Gurohman_E32190192_2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem morfologiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem erosiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dilasiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.morfologiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.erosiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dilasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.morfologiToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(555, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// morfologiToolStripMenuItem
			// 
			this.morfologiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.erosiToolStripMenuItem,
			this.dilasiToolStripMenuItem,
			this.openingToolStripMenuItem,
			this.closingToolStripMenuItem});
			this.morfologiToolStripMenuItem.Name = "morfologiToolStripMenuItem";
			this.morfologiToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.morfologiToolStripMenuItem.Text = "Morfologi";
			// 
			// erosiToolStripMenuItem
			// 
			this.erosiToolStripMenuItem.Name = "erosiToolStripMenuItem";
			this.erosiToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.erosiToolStripMenuItem.Text = "Erosi";
			this.erosiToolStripMenuItem.Click += new System.EventHandler(this.ErosiToolStripMenuItemClick);
			// 
			// dilasiToolStripMenuItem
			// 
			this.dilasiToolStripMenuItem.Name = "dilasiToolStripMenuItem";
			this.dilasiToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.dilasiToolStripMenuItem.Text = "Dilasi";
			this.dilasiToolStripMenuItem.Click += new System.EventHandler(this.DilasiToolStripMenuItemClick);
			// 
			// openingToolStripMenuItem
			// 
			this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
			this.openingToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.openingToolStripMenuItem.Text = "Opening";
			this.openingToolStripMenuItem.Click += new System.EventHandler(this.OpeningToolStripMenuItemClick);
			// 
			// closingToolStripMenuItem
			// 
			this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
			this.closingToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.closingToolStripMenuItem.Text = "Closing";
			this.closingToolStripMenuItem.Click += new System.EventHandler(this.ClosingToolStripMenuItemClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(244, 237);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(281, 27);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(244, 237);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(90, 270);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Open";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(363, 270);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Save";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 343);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Diki_Taufik_Gurohman_E32190192_2";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}