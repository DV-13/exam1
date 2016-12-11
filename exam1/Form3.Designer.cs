namespace exam1
{
	partial class Form3
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
			this.textBox0 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button0 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_header
			// 
			this.label_header.AutoSize = true;
			this.label_header.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label_header.Font = new System.Drawing.Font("Open Sans", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.label_header.Location = new System.Drawing.Point(292, 15);
			this.label_header.Name = "label_header";
			this.label_header.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label_header.Size = new System.Drawing.Size(390, 51);
			this.label_header.TabIndex = 3;
			this.label_header.Text = "Форма авторизации";
			// 
			// label_description
			// 
			this.label_description.AutoSize = true;
			this.label_description.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label_description.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.label_description.Location = new System.Drawing.Point(180, 90);
			this.label_description.Name = "label_description";
			this.label_description.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label_description.Size = new System.Drawing.Size(614, 66);
			this.label_description.TabIndex = 4;
			this.label_description.Text = "Пожалуйста, авторизируйтесь в системе,\r\nиспользуя ваш адрес электронной почты и п" +
    "ароль.";
			this.label_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label0
			// 
			this.label0.AutoSize = true;
			this.label0.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.label0.Location = new System.Drawing.Point(303, 215);
			this.label0.Name = "label0";
			this.label0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label0.Size = new System.Drawing.Size(81, 33);
			this.label0.TabIndex = 5;
			this.label0.Text = "Email:";
			// 
			// textBox0
			// 
			this.textBox0.Font = new System.Drawing.Font("Open Sans", 13.75F);
			this.textBox0.Location = new System.Drawing.Point(390, 215);
			this.textBox0.Name = "textBox0";
			this.textBox0.Size = new System.Drawing.Size(300, 32);
			this.textBox0.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.label1.Location = new System.Drawing.Point(276, 265);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(108, 33);
			this.label1.TabIndex = 7;
			this.label1.Text = "Пароль:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Open Sans", 13.75F);
			this.textBox1.Location = new System.Drawing.Point(390, 265);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(300, 32);
			this.textBox1.TabIndex = 8;
			// 
			// button0
			// 
			this.button0.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button0.Location = new System.Drawing.Point(390, 315);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(100, 35);
			this.button0.TabIndex = 9;
			this.button0.Text = "Login";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.button0_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(508, 315);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 35);
			this.button1.TabIndex = 10;
			this.button1.Text = "Отмена";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(980, 550);
			this.Controls.Add(this.label_header);
			this.Controls.Add(this.label_description);
			this.Controls.Add(this.label0);
			this.Controls.Add(this.textBox0);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(0, 65);
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_header;
		private System.Windows.Forms.Label label_description;
		private System.Windows.Forms.Label label0;
		private System.Windows.Forms.TextBox textBox0;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button button1;
	}
}