namespace uzduotis_zodynelis
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
			this.CommentText = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.Tabai = new System.Windows.Forms.TabControl();
			this.SuspendLayout();
			// 
			// CommentText
			// 
			this.CommentText.Location = new System.Drawing.Point(27, 24);
			this.CommentText.Multiline = true;
			this.CommentText.Name = "CommentText";
			this.CommentText.Size = new System.Drawing.Size(244, 149);
			this.CommentText.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(27, 195);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 56);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Tabai
			// 
			this.Tabai.Location = new System.Drawing.Point(353, 24);
			this.Tabai.Name = "Tabai";
			this.Tabai.SelectedIndex = 0;
			this.Tabai.Size = new System.Drawing.Size(398, 259);
			this.Tabai.TabIndex = 2;
			this.Tabai.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Tabai);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.CommentText);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox CommentText;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabControl Tabai;
	}
}

