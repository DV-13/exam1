namespace exam1
{
	partial class Form7
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
			this.label_header = new System.Windows.Forms.Label();
			this.label_description = new System.Windows.Forms.Label();
			this.label0 = new System.Windows.Forms.Label();
			this.label_subtitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button0 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_header
			// 
			this.label_header.AutoSize = true;
			this.label_header.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label_header.Font = new System.Drawing.Font("Open Sans", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.label_header.Location = new System.Drawing.Point(100, 15);
			this.label_header.Name = "label_header";
			this.label_header.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label_header.Size = new System.Drawing.Size(789, 51);
			this.label_header.TabIndex = 3;
			this.label_header.Text = "Спасибо за вашу спонсорскую поддержку!";
			// 
			// label_description
			// 
			this.label_description.AutoSize = true;
			this.label_description.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label_description.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.label_description.Location = new System.Drawing.Point(90, 75);
			this.label_description.Name = "label_description";
			this.label_description.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label_description.Size = new System.Drawing.Size(821, 66);
			this.label_description.TabIndex = 4;
			this.label_description.Text = "Спасибо за поддержку бегуна в Marathon Skills 2017!\r\nВаше пожертвование пойдет в " +
    "его благотворительную организацию";
			this.label_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label0
			// 
			this.label0.AutoSize = true;
			this.label0.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label0.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.label0.Location = new System.Drawing.Point(370, 180);
			this.label0.Name = "label0";
			this.label0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label0.Size = new System.Drawing.Size(240, 43);
			this.label0.TabIndex = 5;
			this.label0.Text = "sponsor_name";
			this.label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_subtitle
			// 
			this.label_subtitle.AutoSize = true;
			this.label_subtitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label_subtitle.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_subtitle.ForeColor = System.Drawing.Color.Gray;
			this.label_subtitle.Location = new System.Drawing.Point(390, 255);
			this.label_subtitle.Name = "label_subtitle";
			this.label_subtitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label_subtitle.Size = new System.Drawing.Size(205, 39);
			this.label_subtitle.TabIndex = 2;
			this.label_subtitle.Text = "Фонд кошек";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Open Sans", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Gray;
			this.label1.Location = new System.Drawing.Point(395, 295);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(165, 131);
			this.label1.TabIndex = 18;
			this.label1.Text = "$0";
			// 
			// button0
			// 
			this.button0.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button0.Location = new System.Drawing.Point(450, 480);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(100, 35);
			this.button0.TabIndex = 1;
			this.button0.Text = "Назад";
			this.button0.UseVisualStyleBackColor = true;
			// 
			// Form7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(980, 550);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label0);
			this.Controls.Add(this.label_description);
			this.Controls.Add(this.label_subtitle);
			this.Controls.Add(this.label_header);
			this.Controls.Add(this.button0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(0, 65);
			this.Name = "Form7";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form7";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_header;
		private System.Windows.Forms.Label label_description;
		private System.Windows.Forms.Label label0;
		private System.Windows.Forms.Label label_subtitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button0;
	}
}