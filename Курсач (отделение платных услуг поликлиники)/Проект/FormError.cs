using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Проект
{
    public partial class FormError : MetroFramework.Forms.MetroForm
    {
        public FormError()
        {
            InitializeComponent();
        }
        static public string TextError;

        // Ок
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Вставка текста на форму
        private void FormError_Shown(object sender, EventArgs e)
        {
            label1.Text = TextError;
        }
    }
}
