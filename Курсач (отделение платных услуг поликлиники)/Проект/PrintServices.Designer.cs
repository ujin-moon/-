namespace Проект
{
    partial class PrintServices
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
            this.dtUniversal = new System.Windows.Forms.DataGridView();
            this.PoiskTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtUniversal)).BeginInit();
            this.SuspendLayout();
            // 
            // dtUniversal
            // 
            this.dtUniversal.AllowUserToAddRows = false;
            this.dtUniversal.AllowUserToDeleteRows = false;
            this.dtUniversal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtUniversal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dtUniversal.Location = new System.Drawing.Point(12, 46);
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
            this.dtUniversal.Size = new System.Drawing.Size(828, 542);
            this.dtUniversal.TabIndex = 53;
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
            this.PoiskTextBox.MaxLength = 200;
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
            // PrintServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 600);
            this.Controls.Add(this.dtUniversal);
            this.Controls.Add(this.PoiskTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintServices";
            this.Text = "ListSpecialty";
            this.Shown += new System.EventHandler(this.List_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtUniversal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox PoiskTextBox;
        private System.Windows.Forms.DataGridView dtUniversal;
    }
}