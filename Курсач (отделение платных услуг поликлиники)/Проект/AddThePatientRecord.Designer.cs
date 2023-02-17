namespace Проект
{
    partial class AddThePatientRecord
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddThePatientRecord));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.Location = new System.Drawing.Point(-6, -22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 28);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Запись пациента";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.Button2);
            this.panel2.Controls.Add(this.Button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 54);
            this.panel2.TabIndex = 26;
            // 
            // Button2
            // 
            this.Button2.Animated = true;
            this.Button2.AutoRoundedCorners = true;
            this.Button2.BorderRadius = 18;
            this.Button2.CheckedState.Parent = this.Button2;
            this.Button2.CustomImages.Parent = this.Button2;
            this.Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.HoverState.Parent = this.Button2;
            this.Button2.Image = global::Проект.Properties.Resources.Отмена;
            this.Button2.Location = new System.Drawing.Point(268, 8);
            this.Button2.Name = "Button2";
            this.Button2.ShadowDecoration.Parent = this.Button2;
            this.Button2.Size = new System.Drawing.Size(135, 39);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Отмена";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Animated = true;
            this.Button1.AutoRoundedCorners = true;
            this.Button1.BorderRadius = 18;
            this.Button1.CheckedState.Parent = this.Button1;
            this.Button1.CustomImages.Parent = this.Button1;
            this.Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.HoverState.Parent = this.Button1;
            this.Button1.Image = global::Проект.Properties.Resources.Сохранение;
            this.Button1.Location = new System.Drawing.Point(12, 8);
            this.Button1.Name = "Button1";
            this.Button1.ShadowDecoration.Parent = this.Button1;
            this.Button1.Size = new System.Drawing.Size(135, 39);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Сохранить";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.Button4);
            this.panel3.Controls.Add(this.TextBox2);
            this.panel3.Controls.Add(this.Button3);
            this.panel3.Controls.Add(this.TextBox1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 170);
            this.panel3.TabIndex = 27;
            // 
            // Button4
            // 
            this.Button4.Animated = true;
            this.Button4.AutoRoundedCorners = true;
            this.Button4.BorderRadius = 16;
            this.Button4.CheckedState.Parent = this.Button4;
            this.Button4.CustomImages.Parent = this.Button4;
            this.Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.Button4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.HoverState.Parent = this.Button4;
            this.Button4.ImageSize = new System.Drawing.Size(18, 18);
            this.Button4.Location = new System.Drawing.Point(319, 109);
            this.Button4.Name = "Button4";
            this.Button4.ShadowDecoration.Parent = this.Button4;
            this.Button4.Size = new System.Drawing.Size(84, 35);
            this.Button4.TabIndex = 32;
            this.Button4.Text = "Выбрать";
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.Animated = true;
            this.TextBox2.AutoRoundedCorners = true;
            this.TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.TextBox2.BorderRadius = 16;
            this.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox2.DefaultText = "";
            this.TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox2.DisabledState.Parent = this.TextBox2;
            this.TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox2.FocusedState.Parent = this.TextBox2;
            this.TextBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox2.HoverState.Parent = this.TextBox2;
            this.TextBox2.Location = new System.Drawing.Point(12, 109);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox2.MaxLength = 150;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PasswordChar = '\0';
            this.TextBox2.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBox2.PlaceholderText = "Пациент";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.SelectedText = "";
            this.TextBox2.ShadowDecoration.Parent = this.TextBox2;
            this.TextBox2.Size = new System.Drawing.Size(299, 35);
            this.TextBox2.TabIndex = 31;
            // 
            // Button3
            // 
            this.Button3.Animated = true;
            this.Button3.AutoRoundedCorners = true;
            this.Button3.BorderRadius = 16;
            this.Button3.CheckedState.Parent = this.Button3;
            this.Button3.CustomImages.Parent = this.Button3;
            this.Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.HoverState.Parent = this.Button3;
            this.Button3.ImageSize = new System.Drawing.Size(18, 18);
            this.Button3.Location = new System.Drawing.Point(319, 64);
            this.Button3.Name = "Button3";
            this.Button3.ShadowDecoration.Parent = this.Button3;
            this.Button3.Size = new System.Drawing.Size(84, 35);
            this.Button3.TabIndex = 30;
            this.Button3.Text = "Выбрать";
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Animated = true;
            this.TextBox1.AutoRoundedCorners = true;
            this.TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.TextBox1.BorderRadius = 16;
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1.DefaultText = "";
            this.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.DisabledState.Parent = this.TextBox1;
            this.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.FocusedState.Parent = this.TextBox1;
            this.TextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.HoverState.Parent = this.TextBox1;
            this.TextBox1.Location = new System.Drawing.Point(12, 64);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox1.MaxLength = 150;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBox1.PlaceholderText = "Талон";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.SelectedText = "";
            this.TextBox1.ShadowDecoration.Parent = this.TextBox1;
            this.TextBox1.Size = new System.Drawing.Size(299, 35);
            this.TextBox1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::Проект.Properties.Resources.ДобавлениеФорма;
            this.pictureBox1.Location = new System.Drawing.Point(14, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this.panel3;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.ContainerControl = this;
            this.guna2DragControl2.TargetControl = this.panel1;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.ContainerControl = this;
            this.guna2DragControl3.TargetControl = this.label1;
            // 
            // guna2DragControl4
            // 
            this.guna2DragControl4.ContainerControl = this;
            this.guna2DragControl4.TargetControl = this.pictureBox1;
            // 
            // AddThePatientRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 217);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddThePatientRecord";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Запись пациента";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Shown += new System.EventHandler(this.Add_Shown);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button Button1;
        private Guna.UI2.WinForms.Guna2Button Button2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox1;
        private Guna.UI2.WinForms.Guna2Button Button3;
        private Guna.UI2.WinForms.Guna2Button Button4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox2;
    }
}