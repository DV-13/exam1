namespace exam1
{
	partial class Form12
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
			this.pictureBox_image = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox_image
			// 
			this.pictureBox_image.Location = new System.Drawing.Point(0, 0);
			this.pictureBox_image.Name = "pictureBox_image";
			this.pictureBox_image.Size = new System.Drawing.Size(980, 550);
			this.pictureBox_image.TabIndex = 8;
			this.pictureBox_image.TabStop = false;
			// 
			// Form12
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(980, 550);
			this.Controls.Add(this.pictureBox_image);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(0, 65);
			this.Name = "Form12";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form12";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox_image;
	}
}