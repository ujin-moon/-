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
    public partial class FormDelete : MetroFramework.Forms.MetroForm
    {
        public FormDelete()
        {
            InitializeComponent();
        }
        static public bool DeleteBool = false;
        
        // Да
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DeleteBool = true;
            Close();
        }

        // Нет
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DeleteBool = false;
            Close();
        }
    }
}
