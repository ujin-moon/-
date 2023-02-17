namespace Проект
{
    partial class EditingPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingPatient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBox5 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBox8 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox7 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.label1.Size = new System.Drawing.Size(267, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Редактирование пациента";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.Button2);
            this.panel2.Controls.Add(this.Button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 428);
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
            this.Button2.Location = new System.Drawing.Point(267, 8);
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
            this.panel3.Controls.Add(this.TextBox4);
            this.panel3.Controls.Add(this.ComboBox5);
            this.panel3.Controls.Add(this.TextBox8);
            this.panel3.Controls.Add(this.TextBox7);
            this.panel3.Controls.Add(this.TextBox6);
            this.panel3.Controls.Add(this.TextBox3);
            this.panel3.Controls.Add(this.TextBox2);
            this.panel3.Controls.Add(this.TextBox1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 432);
            this.panel3.TabIndex = 27;
            // 
            // TextBox4
            // 
            this.TextBox4.Animated = true;
            this.TextBox4.AutoRoundedCorners = true;
            this.TextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.TextBox4.BorderRadius = 16;
            this.TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox4.DefaultText = "";
            this.TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox4.DisabledState.Parent = this.TextBox4;
            this.TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox4.FocusedState.Parent = this.TextBox4;
            this.TextBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox4.HoverState.Parent = this.TextBox4;
            this.TextBox4.Location = new System.Drawing.Point(12, 199);
            this.TextBox4.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox4.MaxLength = 4;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.PasswordChar = '\0';
            this.TextBox4.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBox4.PlaceholderText = "Год рождения";
            this.TextBox4.SelectedText = "";
            this.TextBox4.ShadowDecoration.Parent = this.TextBox4;
            this.TextBox4.Size = new System.Drawing.Size(391, 35);
            this.TextBox4.TabIndex = 36;
            this.TextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBox1_KeyPress);
            // 
            // ComboBox5
            // 
            this.ComboBox5.Animated = true;
            this.ComboBox5.AutoRoundedCorners = true;
            this.ComboBox5.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.ComboBox5.BorderRadius = 17;
            this.ComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox5.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox5.FocusedState.Parent = this.ComboBox5;
            this.ComboBox5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ComboBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ComboBox5.HoverState.Parent = this.ComboBox5;
            this.ComboBox5.ItemHeight = 30;
            this.ComboBox5.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.ComboBox5.ItemsAppearance.Parent = this.ComboBox5;
            this.ComboBox5.Location = new System.Drawing.Point(12, 242);
            this.ComboBox5.Name = "ComboBox5";
            this.ComboBox5.ShadowDecoration.Parent = this.ComboBox5;
            this.ComboBox5.Size = new System.Drawing.Size(391, 36);
            this.ComboBox5.StartIndex = 0;
            this.ComboBox5.TabIndex = 35;
            // 
            // TextBox8
            // 
            this.TextBox8.Animated = true;
            this.TextBox8.AutoRoundedCorners = true;
            this.TextBox8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.TextBox8.BorderRadius = 16;
            this.TextBox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox8.DefaultText = "";
            this.TextBox8.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox8.DisabledState.Parent = this.TextBox8;
            this.TextBox8.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox8.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox8.FocusedState.Parent = this.TextBox8;
            this.TextBox8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.TextBox8.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox8.HoverState.Parent = this.TextBox8;
            this.TextBox8.Location = new System.Drawing.Point(12, 376);
            this.TextBox8.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox8.MaxLength = 20;
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.PasswordChar = '\0';
            this.TextBox8.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBox8.PlaceholderText = "Паспортные данные";
            this.TextBox8.SelectedText = "";
            this.TextBox8.ShadowDecoration.Parent = this.TextBox8;
            this.TextBox8.Size = new System.Drawing.Size(391, 35);
            this.TextBox8.TabIndex = 34;
            // 
            // TextBox7
            // 
            this.TextBox7.Animated = true;
            this.TextBox7.AutoRoundedCorners = true;
            this.TextBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.TextBox7.BorderRadius = 16;
            this.TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox7.DefaultText = "";
            this.TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox7.DisabledState.Parent = this.TextBox7;
            this.TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox7.FocusedState.Parent = this.TextBox7;
            this.TextBox7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox7.HoverState.Parent = this.TextBox7;
            this.TextBox7.Location = new System.Drawing.Point(12, 331);
            this.TextBox7.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox7.MaxLength = 20;
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.PasswordChar = '\0';
            this.TextBox7.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBox7.PlaceholderText = "Телефон";
            this.TextBox7.SelectedText = "";
            this.TextBox7.ShadowDecoration.Parent = this.TextBox7;
            this.TextBox7.Size = new System.Drawing.Size(391, 35);
            this.TextBox7.TabIndex = 33;
            // 
            // TextBox6
            // 
            this.TextBox6.Animated = true;
            this.TextBox6.AutoRoundedCorners = true;
            this.TextBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.TextBox6.BorderRadius = 16;
            this.TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox6.DefaultText = "";
            this.TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox6.DisabledState.Parent = this.TextBox6;
            this.TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox6.FocusedState.Parent = this.TextBox6;
            this.TextBox6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox6.HoverState.Parent = this.TextBox6;
            this.TextBox6.Location = new System.Drawing.Point(12, 286);
            this.TextBox6.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox6.MaxLength = 150;
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.PasswordChar = '\0';
            this.TextBox6.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBox6.PlaceholderText = "Адрес";
            this.TextBox6.SelectedText = "";
            this.TextBox6.ShadowDecoration.Parent = this.TextBox6;
            this.TextBox6.Size = new System.Drawing.Size(391, 35);
            this.TextBox6.TabIndex = 32;
            // 
            // TextBox3
            // 
            this.TextBox3.Animated = true;
            this.TextBox3.AutoRoundedCorners = true;
            this.TextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.TextBox3.BorderRadius = 16;
            this.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox3.DefaultText = "";
            this.TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox3.DisabledState.Parent = this.TextBox3;
            this.TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox3.FocusedState.Parent = this.TextBox3;
            this.TextBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox3.HoverState.Parent = this.TextBox3;
            this.TextBox3.Location = new System.Drawing.Point(12, 154);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox3.MaxLength = 40;
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.PasswordChar = '\0';
            this.TextBox3.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBox3.PlaceholderText = "Отчество";
            this.TextBox3.SelectedText = "";
            this.TextBox3.ShadowDecoration.Parent = this.TextBox3;
            this.TextBox3.Size = new System.Drawing.Size(391, 35);
            this.TextBox3.TabIndex = 27;
            this.TextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3_KeyPress);
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
            this.TextBox2.MaxLength = 26;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PasswordChar = '\0';
            this.TextBox2.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBox2.PlaceholderText = "Имя";
            this.TextBox2.SelectedText = "";
            this.TextBox2.ShadowDecoration.Parent = this.TextBox2;
            this.TextBox2.Size = new System.Drawing.Size(391, 35);
            this.TextBox2.TabIndex = 26;
            this.TextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
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
            this.TextBox1.MaxLength = 40;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TextBox1.PlaceholderText = "Фамилия";
            this.TextBox1.SelectedText = "";
            this.TextBox1.ShadowDecoration.Parent = this.TextBox1;
            this.TextBox1.Size = new System.Drawing.Size(391, 35);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::Проект.Properties.Resources.РедактированиеФорма;
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
            // EditingPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditingPatient";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Редактирование пациента";
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
        public Guna.UI2.WinForms.Guna2TextBox TextBox1;
        public Guna.UI2.WinForms.Guna2TextBox TextBox3;
        public Guna.UI2.WinForms.Guna2TextBox TextBox2;
        public Guna.UI2.WinForms.Guna2ComboBox ComboBox5;
        public Guna.UI2.WinForms.Guna2TextBox TextBox8;
        public Guna.UI2.WinForms.Guna2TextBox TextBox7;
        public Guna.UI2.WinForms.Guna2TextBox TextBox6;
        public Guna.UI2.WinForms.Guna2TextBox TextBox4;
    }
}