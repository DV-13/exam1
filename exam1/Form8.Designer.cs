namespace exam1
{
	partial class Form8
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
			this.label_description = new System.Windows.Forms.Label();
			this.label_header = new System.Windows.Forms.Label();
			this.label0 = new System.Windows.Forms.Label();
			this.button0 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_description
			// 
			this.label_description.AutoSize = true;
			this.label_description.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label_description.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.label_description.Location = new System.Drawing.Point(72, 134);
			this.label_description.Name = "label_description";
			this.label_description.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label_description.Size = new System.Drawing.Size(844, 33);
			this.label_description.TabIndex = 2;
			this.label_description.Text = "Спасибо за вашу регистрацию в качестве бегуна в Marathon Skills 2017!";
			this.label_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_header
			// 
			this.label_header.AutoSize = true;
			this.label_header.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label_header.Font = new System.Drawing.Font("Open Sans", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.label_header.Location = new System.Drawing.Point(30, 15);
			this.label_header.Name = "label_header";
			this.label_header.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label_header.Size = new System.Drawing.Size(919, 51);
			this.label_header.TabIndex = 2;
			this.label_header.Text = "Спасибо за вашу регистрацию в качестве бегуна!";
			// 
			// label0
			// 
			this.label0.AutoSize = true;
			this.label0.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.label0.Location = new System.Drawing.Point(284, 178);
			this.label0.Name = "label0";
			this.label0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label0.Size = new System.Drawing.Size(426, 33);
			this.label0.TabIndex = 2;
			this.label0.Text = "С вами свяжутся по поводу оплаты.";
			// 
			// button0
			// 
			this.button0.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button0.Location = new System.Drawing.Point(450, 250);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(100, 35);
			this.button0.TabIndex = 1;
			this.button0.Text = "OK";
			this.button0.UseVisualStyleBackColor = true;
			// 
			// Form8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(980, 550);
			this.Controls.Add(this.label_header);
			this.Controls.Add(this.label_description);
			this.Controls.Add(this.label0);
			this.Controls.Add(this.button0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(0, 65);
			this.Name = "Form8";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form8";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_description;
		private System.Windows.Forms.Label label_header;
		private System.Windows.Forms.Label label0;
		private System.Windows.Forms.Button button0;
	}
}