﻿namespace exam1
{
	partial class Form0
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
			this.button_default = new System.Windows.Forms.Button();
			this.button_large = new System.Windows.Forms.Button();
			this.button_big = new System.Windows.Forms.Button();
			this.label_text = new System.Windows.Forms.Label();
			this.textBox_text = new System.Windows.Forms.TextBox();
			this.label_header = new System.Windows.Forms.Label();
			this.label_subtitle = new System.Windows.Forms.Label();
			this.comboBox_list = new System.Windows.Forms.ComboBox();
			this.checkBox_pick = new System.Windows.Forms.CheckBox();
			this.radioButton_pick = new System.Windows.Forms.RadioButton();
			this.pictureBox_image = new System.Windows.Forms.PictureBox();
			this.button_hint = new System.Windows.Forms.Button();
			this.label_description = new System.Windows.Forms.Label();
			this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
			this.tableLayoutPanel_table = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
			this.SuspendLayout();
			// 
			// button_default
			// 
			this.button_default.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_default.Location = new System.Drawing.Point(865, 210);
			this.button_default.Name = "button_default";
			this.button_default.Size = new System.Drawing.Size(100, 35);
			this.button_default.TabIndex = 1;
			this.button_default.Text = "default";
			this.button_default.UseVisualStyleBackColor = true;
			// 
			// button_large
			// 
			this.button_large.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_large.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.button_large.Location = new System.Drawing.Point(15, 210);
			this.button_large.Name = "button_large";
			this.button_large.Size = new System.Drawing.Size(467, 90);
			this.button_large.TabIndex = 1;
			this.button_large.Text = "large\r\nlarge";
			this.button_large.UseVisualStyleBackColor = true;
			// 
			// button_big
			// 
			this.button_big.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_big.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.button_big.Location = new System.Drawing.Point(498, 210);
			this.button_big.Name = "button_big";
			this.button_big.Size = new System.Drawing.Size(350, 90);
			this.button_big.TabIndex = 1;
			this.button_big.Text = "big\r\nbig";
			this.button_big.UseVisualStyleBackColor = true;
			// 
			// label_text
			// 
			this.label_text.AutoSize = true;
			this.label_text.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.label_text.Location = new System.Drawing.Point(93, 160);
			this.label_text.Name = "label_text";
			this.label_text.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label_text.Size = new System.Drawing.Size(81, 33);
			this.label_text.TabIndex = 2;
			this.label_text.Text = "Текст:";
			// 
			// textBox_text
			// 
			this.textBox_text.Font = new System.Drawing.Font("Open Sans", 13.75F);
			this.textBox_text.Location = new System.Drawing.Point(180, 160);
			this.textBox_text.Name = "textBox_text";
			this.textBox_text.Size = new System.Drawing.Size(300, 32);
			this.textBox_text.TabIndex = 3;
			// 
			// label_header
			// 
			this.label_header.AutoSize = true;
			this.label_header.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label_header.Font = new System.Drawing.Font("Open Sans", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.label_header.Location = new System.Drawing.Point(388, 15);
			this.label_header.Name = "label_header";
			this.label_header.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label_header.Size = new System.Drawing.Size(207, 51);
			this.label_header.TabIndex = 2;
			this.label_header.Text = "Заголовок";
			// 
			// label_subtitle
			// 
			this.label_subtitle.AutoSize = true;
			this.label_subtitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label_subtitle.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_subtitle.ForeColor = System.Drawing.Color.Gray;
			this.label_subtitle.Location = new System.Drawing.Point(391, 113);
			this.label_subtitle.Name = "label_subtitle";
			this.label_subtitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label_subtitle.Size = new System.Drawing.Size(192, 33);
			this.label_subtitle.TabIndex = 2;
			this.label_subtitle.Text = "Подзаголовок";
			// 
			// comboBox_list
			// 
			this.comboBox_list.Font = new System.Drawing.Font("Open Sans", 13.75F);
			this.comboBox_list.FormattingEnabled = true;
			this.comboBox_list.Items.AddRange(new object[] {
            "Первый",
            "Второй"});
			this.comboBox_list.Location = new System.Drawing.Point(500, 160);
			this.comboBox_list.Name = "comboBox_list";
			this.comboBox_list.Size = new System.Drawing.Size(200, 32);
			this.comboBox_list.TabIndex = 5;
			// 
			// checkBox_pick
			// 
			this.checkBox_pick.AutoSize = true;
			this.checkBox_pick.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBox_pick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.checkBox_pick.Location = new System.Drawing.Point(375, 320);
			this.checkBox_pick.Name = "checkBox_pick";
			this.checkBox_pick.Size = new System.Drawing.Size(149, 37);
			this.checkBox_pick.TabIndex = 6;
			this.checkBox_pick.Text = "Параметр";
			this.checkBox_pick.UseVisualStyleBackColor = true;
			// 
			// radioButton_pick
			// 
			this.radioButton_pick.AutoSize = true;
			this.radioButton_pick.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.radioButton_pick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.radioButton_pick.Location = new System.Drawing.Point(375, 360);
			this.radioButton_pick.Name = "radioButton_pick";
			this.radioButton_pick.Size = new System.Drawing.Size(131, 37);
			this.radioButton_pick.TabIndex = 7;
			this.radioButton_pick.TabStop = true;
			this.radioButton_pick.Text = "Вариант";
			this.radioButton_pick.UseVisualStyleBackColor = true;
			// 
			// pictureBox_image
			// 
			this.pictureBox_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox_image.Location = new System.Drawing.Point(15, 320);
			this.pictureBox_image.Name = "pictureBox_image";
			this.pictureBox_image.Size = new System.Drawing.Size(120, 160);
			this.pictureBox_image.TabIndex = 8;
			this.pictureBox_image.TabStop = false;
			// 
			// button_hint
			// 
			this.button_hint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.button_hint.Cursor = System.Windows.Forms.Cursors.Default;
			this.button_hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_hint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.button_hint.Location = new System.Drawing.Point(530, 320);
			this.button_hint.Name = "button_hint";
			this.button_hint.Size = new System.Drawing.Size(20, 20);
			this.button_hint.TabIndex = 10;
			this.button_hint.Text = "?";
			this.button_hint.UseVisualStyleBackColor = false;
			// 
			// label_description
			// 
			this.label_description.AutoSize = true;
			this.label_description.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label_description.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.label_description.Location = new System.Drawing.Point(428, 71);
			this.label_description.Name = "label_description";
			this.label_description.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label_description.Size = new System.Drawing.Size(131, 33);
			this.label_description.TabIndex = 2;
			this.label_description.Text = "Описание";
			this.label_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dateTimePicker_date
			// 
			this.dateTimePicker_date.CalendarFont = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker_date.Font = new System.Drawing.Font("Open Sans", 13.75F);
			this.dateTimePicker_date.Location = new System.Drawing.Point(720, 160);
			this.dateTimePicker_date.Name = "dateTimePicker_date";
			this.dateTimePicker_date.Size = new System.Drawing.Size(170, 32);
			this.dateTimePicker_date.TabIndex = 11;
			// 
			// tableLayoutPanel_table
			// 
			this.tableLayoutPanel_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel_table.ColumnCount = 2;
			this.tableLayoutPanel_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel_table.Location = new System.Drawing.Point(150, 320);
			this.tableLayoutPanel_table.Name = "tableLayoutPanel_table";
			this.tableLayoutPanel_table.RowCount = 3;
			this.tableLayoutPanel_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.tableLayoutPanel_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.tableLayoutPanel_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.tableLayoutPanel_table.Size = new System.Drawing.Size(200, 120);
			this.tableLayoutPanel_table.TabIndex = 12;
			// 
			// Form0
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(980, 550);
			this.Controls.Add(this.label_header);
			this.Controls.Add(this.label_description);
			this.Controls.Add(this.label_subtitle);
			this.Controls.Add(this.label_text);
			this.Controls.Add(this.textBox_text);
			this.Controls.Add(this.comboBox_list);
			this.Controls.Add(this.dateTimePicker_date);
			this.Controls.Add(this.button_large);
			this.Controls.Add(this.button_big);
			this.Controls.Add(this.button_default);
			this.Controls.Add(this.pictureBox_image);
			this.Controls.Add(this.tableLayoutPanel_table);
			this.Controls.Add(this.checkBox_pick);
			this.Controls.Add(this.radioButton_pick);
			this.Controls.Add(this.button_hint);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(0, 65);
			this.Name = "Form0";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_default;
		private System.Windows.Forms.Button button_large;
		private System.Windows.Forms.Button button_big;
		private System.Windows.Forms.Label label_text;
		private System.Windows.Forms.TextBox textBox_text;
		private System.Windows.Forms.Label label_header;
		private System.Windows.Forms.Label label_subtitle;
		private System.Windows.Forms.ComboBox comboBox_list;
		private System.Windows.Forms.CheckBox checkBox_pick;
		private System.Windows.Forms.RadioButton radioButton_pick;
		private System.Windows.Forms.PictureBox pictureBox_image;
		private System.Windows.Forms.Button button_hint;
		private System.Windows.Forms.Label label_description;
		private System.Windows.Forms.DateTimePicker dateTimePicker_date;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_table;
	}
}