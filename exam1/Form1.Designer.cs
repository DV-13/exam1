namespace exam1
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
			this.panel_topbar = new System.Windows.Forms.Panel();
			this.label_top = new System.Windows.Forms.Label();
			this.label_header = new System.Windows.Forms.Label();
			this.button0 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel_topbar.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_topbar
			// 
			this.panel_topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel_topbar.Controls.Add(this.label_top);
			this.panel_topbar.Controls.Add(this.label_header);
			this.panel_topbar.Location = new System.Drawing.Point(0, 0);
			this.panel_topbar.Name = "panel_topbar";
			this.panel_topbar.Size = new System.Drawing.Size(980, 150);
			this.panel_topbar.TabIndex = 13;
			// 
			// label_top
			// 
			this.label_top.AutoSize = true;
			this.label_top.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_top.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label_top.Location = new System.Drawing.Point(190, -10);
			this.label_top.Name = "label_top";
			this.label_top.Size = new System.Drawing.Size(599, 65);
			this.label_top.TabIndex = 14;
			this.label_top.Text = "MARATHON SKILLS 2017";
			// 
			// label_header
			// 
			this.label_header.AutoSize = true;
			this.label_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label_header.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_header.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label_header.Location = new System.Drawing.Point(352, 74);
			this.label_header.Name = "label_header";
			this.label_header.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label_header.Size = new System.Drawing.Size(274, 66);
			this.label_header.TabIndex = 14;
			this.label_header.Text = "Москва, Россия\r\nсреда 18 октября 2017";
			this.label_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button0
			// 
			this.button0.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.button0.Location = new System.Drawing.Point(15, 165);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(467, 90);
			this.button0.TabIndex = 14;
			this.button0.Text = "Я хочу стать бегуном";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.button0_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.button1.Location = new System.Drawing.Point(498, 165);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(467, 90);
			this.button1.TabIndex = 14;
			this.button1.Text = "Я хочу стать зрителем";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.button2.Location = new System.Drawing.Point(15, 275);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(467, 90);
			this.button2.TabIndex = 14;
			this.button2.Text = "Я хочу стать спонсором бегуна";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.button3.Location = new System.Drawing.Point(498, 275);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(467, 90);
			this.button3.TabIndex = 14;
			this.button3.Text = "Я хочу узнать больше о событии";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(980, 550);
			this.Controls.Add(this.panel_topbar);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(0, 65);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form1";
			this.panel_topbar.ResumeLayout(false);
			this.panel_topbar.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_topbar;
		private System.Windows.Forms.Label label_header;
		private System.Windows.Forms.Label label_top;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}