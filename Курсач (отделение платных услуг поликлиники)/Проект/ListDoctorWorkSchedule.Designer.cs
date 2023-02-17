namespace Проект
{
    partial class ListDoctorWorkSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EddButton = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.PoiskTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtUniversal = new System.Windows.Forms.DataGridView();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUniversal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.EddButton);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 514);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 74);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // EddButton
            // 
            this.EddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EddButton.Animated = true;
            this.EddButton.AutoRoundedCorners = true;
            this.EddButton.BorderRadius = 21;
            this.EddButton.CheckedState.Parent = this.EddButton;
            this.EddButton.CustomImages.Parent = this.EddButton;
            this.EddButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.EddButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.EddButton.ForeColor = System.Drawing.Color.White;
            this.EddButton.HoverState.Parent = this.EddButton;
            this.EddButton.Image = global::Проект.Properties.Resources.Редактирование;
            this.EddButton.ImageSize = new System.Drawing.Size(24, 24);
            this.EddButton.Location = new System.Drawing.Point(280, 18);
            this.EddButton.Name = "EddButton";
            this.EddButton.ShadowDecoration.Parent = this.EddButton;
            this.EddButton.Size = new System.Drawing.Size(268, 45);
            this.EddButton.TabIndex = 2;
            this.EddButton.Text = "Редактировать";
            this.EddButton.Click += new System.EventHandler(this.EddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Animated = true;
            this.DeleteButton.AutoRoundedCorners = true;
            this.DeleteButton.BorderRadius = 21;
            this.DeleteButton.CheckedState.Parent = this.DeleteButton;
            this.DeleteButton.CustomImages.Parent = this.DeleteButton;
            this.DeleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.HoverState.Parent = this.DeleteButton;
            this.DeleteButton.Image = global::Проект.Properties.Resources.Удаление;
            this.DeleteButton.ImageSize = new System.Drawing.Size(24, 24);
            this.DeleteButton.Location = new System.Drawing.Point(554, 18);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ShadowDecoration.Parent = this.DeleteButton;
            this.DeleteButton.Size = new System.Drawing.Size(268, 45);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Animated = true;
            this.AddButton.AutoRoundedCorners = true;
            this.AddButton.BorderRadius = 21;
            this.AddButton.CheckedState.Parent = this.AddButton;
            this.AddButton.CustomImages.Parent = this.AddButton;
            this.AddButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.HoverState.Parent = this.AddButton;
            this.AddButton.Image = global::Проект.Properties.Resources.Добавление;
            this.AddButton.ImageSize = new System.Drawing.Size(24, 24);
            this.AddButton.Location = new System.Drawing.Point(6, 18);
            this.AddButton.Name = "AddButton";
            this.AddButton.ShadowDecoration.Parent = this.AddButton;
            this.AddButton.Size = new System.Drawing.Size(268, 45);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // PoiskTextBox
            // 
            this.PoiskTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PoiskTextBox.Animated = true;
            this.PoiskTextBox.AutoRoundedCorners = true;
            this.PoiskTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.PoiskTextBox.BorderRadius = 12;
            this.PoiskTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PoiskTextBox.DefaultText = "";
            this.PoiskTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PoiskTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PoiskTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PoiskTextBox.DisabledState.Parent = this.PoiskTextBox;
            this.PoiskTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PoiskTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PoiskTextBox.FocusedState.Parent = this.PoiskTextBox;
            this.PoiskTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PoiskTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.PoiskTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PoiskTextBox.HoverState.Parent = this.PoiskTextBox;
            this.PoiskTextBox.IconLeft = global::Проект.Properties.Resources.Поиск;
            this.PoiskTextBox.IconLeftSize = new System.Drawing.Size(17, 17);
            this.PoiskTextBox.Location = new System.Drawing.Point(12, 12);
            this.PoiskTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PoiskTextBox.MaxLength = 110;
            this.PoiskTextBox.Name = "PoiskTextBox";
            this.PoiskTextBox.PasswordChar = '\0';
            this.PoiskTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.PoiskTextBox.PlaceholderText = "Поиск";
            this.PoiskTextBox.SelectedText = "";
            this.PoiskTextBox.ShadowDecoration.Parent = this.PoiskTextBox;
            this.PoiskTextBox.Size = new System.Drawing.Size(828, 27);
            this.PoiskTextBox.TabIndex = 51;
            this.PoiskTextBox.TextChanged += new System.EventHandler(this.PoiskTextBox_TextChanged);
            // 
            // dtUniversal
            // 
            this.dtUniversal.AllowUserToAddRows = false;
            this.dtUniversal.AllowUserToDeleteRows = false;
            this.dtUniversal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtUniversal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtUniversal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtUniversal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtUniversal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtUniversal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtUniversal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtUniversal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtUniversal.ColumnHeadersHeight = 30;
            this.dtUniversal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtUniversal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtUniversal.EnableHeadersVisualStyles = false;
            this.dtUniversal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.dtUniversal.Location = new System.Drawing.Point(12, 85);
            this.dtUniversal.MultiSelect = false;
            this.dtUniversal.Name = "dtUniversal";
            this.dtUniversal.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtUniversal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtUniversal.RowHeadersVisible = false;
            this.dtUniversal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtUniversal.Size = new System.Drawing.Size(828, 423);
            this.dtUniversal.TabIndex = 54;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(514, 46);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(264, 27);
            this.guna2HtmlLabel2.TabIndex = 71;
            this.guna2HtmlLabel2.Text = "Включить/выключить фильтр:";
            // 
            // ToggleSwitch1
            // 
            this.ToggleSwitch1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToggleSwitch1.Animated = true;
            this.ToggleSwitch1.AutoRoundedCorners = true;
            this.ToggleSwitch1.BackColor = System.Drawing.SystemColors.Control;
            this.ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ToggleSwitch1.CheckedState.BorderRadius = 13;
            this.ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch1.CheckedState.InnerBorderRadius = 9;
            this.ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch1.CheckedState.Parent = this.ToggleSwitch1;
            this.ToggleSwitch1.Location = new System.Drawing.Point(784, 46);
            this.ToggleSwitch1.Name = "ToggleSwitch1";
            this.ToggleSwitch1.ShadowDecoration.Parent = this.ToggleSwitch1;
            this.ToggleSwitch1.Size = new System.Drawing.Size(56, 29);
            this.ToggleSwitch1.TabIndex = 70;
            this.ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch1.UncheckedState.BorderRadius = 13;
            this.ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleSwitch1.UncheckedState.InnerBorderRadius = 9;
            this.ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ToggleSwitch1.UncheckedState.Parent = this.ToggleSwitch1;
            this.ToggleSwitch1.CheckedChanged += new System.EventHandler(this.ToggleSwitch1_CheckedChanged_1);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 46);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(141, 27);
            this.guna2HtmlLabel1.TabIndex = 69;
            this.guna2HtmlLabel1.Text = "Фильтр по дате:";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker1.Animated = true;
            this.DateTimePicker1.AutoRoundedCorners = true;
            this.DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.DateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.DateTimePicker1.BorderRadius = 16;
            this.DateTimePicker1.BorderThickness = 1;
            this.DateTimePicker1.CheckedState.Parent = this.DateTimePicker1;
            this.DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DateTimePicker1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePicker1.HoverState.Parent = this.DateTimePicker1;
            this.DateTimePicker1.Location = new System.Drawing.Point(159, 44);
            this.DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.ShadowDecoration.Parent = this.DateTimePicker1;
            this.DateTimePicker1.Size = new System.Drawing.Size(349, 35);
            this.DateTimePicker1.TabIndex = 68;
            this.DateTimePicker1.Value = new System.DateTime(2021, 2, 19, 0, 0, 0, 0);
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // ListDoctorWorkSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 600);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.ToggleSwitch1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.dtUniversal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PoiskTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListDoctorWorkSchedule";
            this.Text = "ListSpecialty";
            this.Shown += new System.EventHandler(this.List_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtUniversal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox PoiskTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2Button EddButton;
        private System.Windows.Forms.DataGridView dtUniversal;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ToggleSwitch1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePicker1;
    }
}