using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ColorProgressBarExample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private ColorProgressBar.ColorProgressBar cpb1;
		private ColorProgressBar.ColorProgressBar cpb2;
		private ColorProgressBar.ColorProgressBar cpb3;
		private ColorProgressBar.ColorProgressBar cpb4;
		private ColorProgressBar.ColorProgressBar cpb5;
		private ColorProgressBar.ColorProgressBar cpb6;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.cpb1 = new ColorProgressBar.ColorProgressBar();
			this.cpb2 = new ColorProgressBar.ColorProgressBar();
			this.cpb3 = new ColorProgressBar.ColorProgressBar();
			this.cpb4 = new ColorProgressBar.ColorProgressBar();
			this.cpb5 = new ColorProgressBar.ColorProgressBar();
			this.cpb6 = new ColorProgressBar.ColorProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// cpb1
			// 
			this.cpb1.BarColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.cpb1.BorderColor = System.Drawing.Color.Black;
			this.cpb1.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Dashed;
			this.cpb1.Location = new System.Drawing.Point(56, 48);
			this.cpb1.Maximum = 100;
			this.cpb1.Minimum = 0;
			this.cpb1.Name = "cpb1";
			this.cpb1.Size = new System.Drawing.Size(150, 15);
			this.cpb1.Step = 10;
			this.cpb1.TabIndex = 0;
			this.cpb1.Value = 0;
			// 
			// cpb2
			// 
			this.cpb2.BarColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.cpb2.BorderColor = System.Drawing.Color.Black;
			this.cpb2.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Solid;
			this.cpb2.Location = new System.Drawing.Point(56, 72);
			this.cpb2.Maximum = 100;
			this.cpb2.Minimum = 0;
			this.cpb2.Name = "cpb2";
			this.cpb2.Size = new System.Drawing.Size(150, 15);
			this.cpb2.Step = 10;
			this.cpb2.TabIndex = 1;
			this.cpb2.Value = 100;
			// 
			// cpb3
			// 
			this.cpb3.BarColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(255)), ((System.Byte)(128)));
			this.cpb3.BorderColor = System.Drawing.Color.Black;
			this.cpb3.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Dashed;
			this.cpb3.Location = new System.Drawing.Point(56, 104);
			this.cpb3.Maximum = 100;
			this.cpb3.Minimum = 0;
			this.cpb3.Name = "cpb3";
			this.cpb3.Size = new System.Drawing.Size(192, 24);
			this.cpb3.Step = 10;
			this.cpb3.TabIndex = 2;
			this.cpb3.Value = 0;
			// 
			// cpb4
			// 
			this.cpb4.BarColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.cpb4.BorderColor = System.Drawing.Color.Black;
			this.cpb4.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Solid;
			this.cpb4.Location = new System.Drawing.Point(56, 144);
			this.cpb4.Maximum = 100;
			this.cpb4.Minimum = 0;
			this.cpb4.Name = "cpb4";
			this.cpb4.Size = new System.Drawing.Size(192, 24);
			this.cpb4.Step = 10;
			this.cpb4.TabIndex = 3;
			this.cpb4.Value = 100;
			// 
			// cpb5
			// 
			this.cpb5.BarColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.cpb5.BorderColor = System.Drawing.Color.Black;
			this.cpb5.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Solid;
			this.cpb5.Location = new System.Drawing.Point(56, 184);
			this.cpb5.Maximum = 100;
			this.cpb5.Minimum = 0;
			this.cpb5.Name = "cpb5";
			this.cpb5.Size = new System.Drawing.Size(272, 32);
			this.cpb5.Step = 10;
			this.cpb5.TabIndex = 4;
			this.cpb5.Value = 0;
			// 
			// cpb6
			// 
			this.cpb6.BarColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.cpb6.BorderColor = System.Drawing.Color.Black;
			this.cpb6.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Dashed;
			this.cpb6.Location = new System.Drawing.Point(56, 232);
			this.cpb6.Maximum = 100;
			this.cpb6.Minimum = 0;
			this.cpb6.Name = "cpb6";
			this.cpb6.Size = new System.Drawing.Size(272, 32);
			this.cpb6.Step = 10;
			this.cpb6.TabIndex = 5;
			this.cpb6.Value = 100;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(384, 310);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.cpb6,
																		  this.cpb5,
																		  this.cpb4,
																		  this.cpb3,
																		  this.cpb2,
																		  this.cpb1});
			this.Name = "Form1";
			this.Text = "Example";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			//
			// All values are reseted at the end
			//
			cpb1.PerformStep();
			if (cpb1.Value == cpb1.Maximum)
				cpb1.Value = cpb1.Minimum;

			cpb2.PerformStepBack();
			if (cpb2.Value == cpb2.Minimum)
				cpb2.Value = cpb2.Maximum;

			cpb3.Increment(1);
			if (cpb3.Value == cpb3.Maximum)
				cpb3.Value = cpb3.Minimum;

			cpb4.Decrement(1);
			if (cpb4.Value == cpb4.Minimum)
				cpb4.Value = cpb4.Maximum;

			cpb5.Increment(1);
			if (cpb5.Value == cpb5.Maximum)
				cpb5.Value = cpb5.Minimum;

			cpb6.Decrement(1);
			if (cpb6.Value == cpb6.Minimum)
				cpb6.Value = cpb6.Maximum;
		}
	}
}
