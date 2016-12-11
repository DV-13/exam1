namespace exam1
{
	partial class Form2
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
			this.button0 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button0
			// 
			this.button0.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.button0.Location = new System.Drawing.Point(250, 175);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(467, 90);
			this.button0.TabIndex = 2;
			this.button0.Text = "Я участвовал ранее";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.button0_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.button1.Location = new System.Drawing.Point(250, 280);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(467, 90);
			this.button1.TabIndex = 3;
			this.button1.Text = "Я новый участник";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(980, 550);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(0, 65);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form2";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button button1;
	}
}