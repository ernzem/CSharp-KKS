namespace WindowsFormsApp2_uz2
{
	partial class Form1
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
			this.BTchooseImage = new System.Windows.Forms.Button();
			this.PBshowImage = new System.Windows.Forms.PictureBox();
			this.TBimagePath = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.PBshowImage)).BeginInit();
			this.SuspendLayout();
			// 
			// BTchooseImage
			// 
			this.BTchooseImage.Location = new System.Drawing.Point(989, 565);
			this.BTchooseImage.Name = "BTchooseImage";
			this.BTchooseImage.Size = new System.Drawing.Size(135, 67);
			this.BTchooseImage.TabIndex = 0;
			this.BTchooseImage.Text = "Pasirinkti Nuotrauka";
			this.BTchooseImage.UseVisualStyleBackColor = true;
			this.BTchooseImage.Click += new System.EventHandler(this.button1_Click);
			// 
			// PBshowImage
			// 
			this.PBshowImage.Location = new System.Drawing.Point(124, 77);
			this.PBshowImage.Name = "PBshowImage";
			this.PBshowImage.Size = new System.Drawing.Size(787, 470);
			this.PBshowImage.TabIndex = 1;
			this.PBshowImage.TabStop = false;
			// 
			// TBimagePath
			// 
			this.TBimagePath.Location = new System.Drawing.Point(310, 31);
			this.TBimagePath.Name = "TBimagePath";
			this.TBimagePath.Size = new System.Drawing.Size(412, 20);
			this.TBimagePath.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1136, 644);
			this.Controls.Add(this.TBimagePath);
			this.Controls.Add(this.PBshowImage);
			this.Controls.Add(this.BTchooseImage);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.PBshowImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BTchooseImage;
		private System.Windows.Forms.PictureBox PBshowImage;
		private System.Windows.Forms.TextBox TBimagePath;
	}
}

