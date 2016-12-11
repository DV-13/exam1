namespace exam1
{
	partial class FormMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel_topbar = new System.Windows.Forms.Panel();
			this.label_top = new System.Windows.Forms.Label();
			this.button_home = new System.Windows.Forms.Button();
			this.button_logout = new System.Windows.Forms.Button();
			this.button_back = new System.Windows.Forms.Button();
			this.panel_bottom = new System.Windows.Forms.Panel();
			this.label_timer = new System.Windows.Forms.Label();
			this.panel_topbar.SuspendLayout();
			this.panel_bottom.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_topbar
			// 
			this.panel_topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel_topbar.Controls.Add(this.label_top);
			this.panel_topbar.Controls.Add(this.button_home);
			this.panel_topbar.Controls.Add(this.button_logout);
			this.panel_topbar.Controls.Add(this.button_back);
			this.panel_topbar.Location = new System.Drawing.Point(2, 2);
			this.panel_topbar.Name = "panel_topbar";
			this.panel_topbar.Size = new System.Drawing.Size(980, 65);
			this.panel_topbar.TabIndex = 1;
			// 
			// label_top
			// 
			this.label_top.AutoSize = true;
			this.label_top.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_top.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label_top.Location = new System.Drawing.Point(170, 10);
			this.label_top.Name = "label_top";
			this.label_top.Size = new System.Drawing.Size(400, 43);
			this.label_top.TabIndex = 1;
			this.label_top.Text = "MARATHON SKILLS 2016";
			// 
			// button_home
			// 
			this.button_home.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_home.Location = new System.Drawing.Point(130, 15);
			this.button_home.Name = "button_home";
			this.button_home.Size = new System.Drawing.Size(35, 35);
			this.button_home.TabIndex = 0;
			this.button_home.Text = "🏠";
			this.button_home.UseVisualStyleBackColor = true;
			this.button_home.Click += new System.EventHandler(this.button_home_Click);
			// 
			// button_logout
			// 
			this.button_logout.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_logout.Location = new System.Drawing.Point(865, 15);
			this.button_logout.Name = "button_logout";
			this.button_logout.Size = new System.Drawing.Size(100, 35);
			this.button_logout.TabIndex = 0;
			this.button_logout.Text = "Logout";
			this.button_logout.UseVisualStyleBackColor = true;
			// 
			// button_back
			// 
			this.button_back.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_back.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button_back.Location = new System.Drawing.Point(15, 15);
			this.button_back.Name = "button_back";
			this.button_back.Size = new System.Drawing.Size(100, 35);
			this.button_back.TabIndex = 0;
			this.button_back.Text = "Назад";
			this.button_back.UseVisualStyleBackColor = true;
			this.button_back.Click += new System.EventHandler(this.button_back_Click);
			// 
			// panel_bottom
			// 
			this.panel_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel_bottom.Controls.Add(this.label_timer);
			this.panel_bottom.Location = new System.Drawing.Point(2, 617);
			this.panel_bottom.Name = "panel_bottom";
			this.panel_bottom.Size = new System.Drawing.Size(980, 42);
			this.panel_bottom.TabIndex = 1;
			// 
			// label_timer
			// 
			this.label_timer.AutoSize = true;
			this.label_timer.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_timer.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label_timer.Location = new System.Drawing.Point(400, 3);
			this.label_timer.Name = "label_timer";
			this.label_timer.Size = new System.Drawing.Size(184, 33);
			this.label_timer.TabIndex = 1;
			this.label_timer.Text = "█label_timer█";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(984, 661);
			this.Controls.Add(this.panel_topbar);
			this.Controls.Add(this.panel_bottom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IsMdiContainer = true;
			this.Name = "FormMain";
			this.Text = "Marathon Skills";
			this.MdiChildActivate += new System.EventHandler(this.FormMain_MdiChildActivate);
			this.panel_topbar.ResumeLayout(false);
			this.panel_topbar.PerformLayout();
			this.panel_bottom.ResumeLayout(false);
			this.panel_bottom.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_topbar;
		private System.Windows.Forms.Button button_back;
		private System.Windows.Forms.Button button_logout;
		private System.Windows.Forms.Label label_top;
		private System.Windows.Forms.Button button_home;
		private System.Windows.Forms.Panel panel_bottom;
		private System.Windows.Forms.Label label_timer;
	}
}

