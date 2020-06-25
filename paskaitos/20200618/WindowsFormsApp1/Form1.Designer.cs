namespace WindowsFormsApp1
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
			this.mygtukas = new System.Windows.Forms.Button();
			this.userText = new System.Windows.Forms.TextBox();
			this.pswrdText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.loginBox1 = new System.Windows.Forms.GroupBox();
			this.duomenuAtvaizdavimas = new System.Windows.Forms.DataGridView();
			this.Varnele_checkBox = new System.Windows.Forms.CheckBox();
			this.pictureBoxNuotrauka = new System.Windows.Forms.PictureBox();
			this.loginBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.duomenuAtvaizdavimas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxNuotrauka)).BeginInit();
			this.SuspendLayout();
			// 
			// mygtukas
			// 
			this.mygtukas.Location = new System.Drawing.Point(676, 392);
			this.mygtukas.Name = "mygtukas";
			this.mygtukas.Size = new System.Drawing.Size(112, 46);
			this.mygtukas.TabIndex = 0;
			this.mygtukas.Text = "Mano Tekstas";
			this.mygtukas.UseVisualStyleBackColor = true;
			this.mygtukas.Click += new System.EventHandler(this.button1_Click);
			// 
			// userText
			// 
			this.userText.Location = new System.Drawing.Point(100, 19);
			this.userText.Name = "userText";
			this.userText.Size = new System.Drawing.Size(100, 20);
			this.userText.TabIndex = 1;
			// 
			// pswrdText
			// 
			this.pswrdText.Location = new System.Drawing.Point(100, 62);
			this.pswrdText.Name = "pswrdText";
			this.pswrdText.PasswordChar = '*';
			this.pswrdText.Size = new System.Drawing.Size(100, 20);
			this.pswrdText.TabIndex = 2;
			this.pswrdText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Username";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// loginBox1
			// 
			this.loginBox1.Controls.Add(this.userText);
			this.loginBox1.Controls.Add(this.label2);
			this.loginBox1.Controls.Add(this.pswrdText);
			this.loginBox1.Controls.Add(this.label1);
			this.loginBox1.Location = new System.Drawing.Point(42, 39);
			this.loginBox1.Name = "loginBox1";
			this.loginBox1.Size = new System.Drawing.Size(246, 137);
			this.loginBox1.TabIndex = 5;
			this.loginBox1.TabStop = false;
			this.loginBox1.Text = "Login";
			// 
			// duomenuAtvaizdavimas
			// 
			this.duomenuAtvaizdavimas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.duomenuAtvaizdavimas.Location = new System.Drawing.Point(42, 212);
			this.duomenuAtvaizdavimas.Name = "duomenuAtvaizdavimas";
			this.duomenuAtvaizdavimas.Size = new System.Drawing.Size(240, 150);
			this.duomenuAtvaizdavimas.TabIndex = 6;
			// 
			// Varnele_checkBox
			// 
			this.Varnele_checkBox.AutoSize = true;
			this.Varnele_checkBox.Location = new System.Drawing.Point(511, 58);
			this.Varnele_checkBox.Name = "Varnele_checkBox";
			this.Varnele_checkBox.Size = new System.Drawing.Size(62, 17);
			this.Varnele_checkBox.TabIndex = 7;
			this.Varnele_checkBox.Text = "Varnele";
			this.Varnele_checkBox.UseVisualStyleBackColor = true;
			// 
			// pictureBoxNuotrauka
			// 
			this.pictureBoxNuotrauka.Location = new System.Drawing.Point(445, 146);
			this.pictureBoxNuotrauka.Name = "pictureBoxNuotrauka";
			this.pictureBoxNuotrauka.Size = new System.Drawing.Size(286, 143);
			this.pictureBoxNuotrauka.TabIndex = 8;
			this.pictureBoxNuotrauka.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBoxNuotrauka);
			this.Controls.Add(this.Varnele_checkBox);
			this.Controls.Add(this.duomenuAtvaizdavimas);
			this.Controls.Add(this.loginBox1);
			this.Controls.Add(this.mygtukas);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Rimta programa";
			this.loginBox1.ResumeLayout(false);
			this.loginBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.duomenuAtvaizdavimas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxNuotrauka)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button mygtukas;
		private System.Windows.Forms.TextBox userText;
		private System.Windows.Forms.TextBox pswrdText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox loginBox1;
		private System.Windows.Forms.DataGridView duomenuAtvaizdavimas;
		private System.Windows.Forms.CheckBox Varnele_checkBox;
		private System.Windows.Forms.PictureBox pictureBoxNuotrauka;
	}
}

