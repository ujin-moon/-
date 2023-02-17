using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Проект
{
    public partial class AddSpecialty : MetroFramework.Forms.MetroForm
    {
        public AddSpecialty()
        {
            InitializeComponent();
        }

        // Подключение
        SqlConnection SC;
        private void Add_Shown(object sender, EventArgs e)
        {
            ConnectionClass z = new ConnectionClass();
            SC = z.ConnectBD();
            SC.Open();
        }

        // Сохранить
        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.TextLength > 0)
            {
                var sqlCmd = new SqlCommand("AddSpecialty", SC);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Наименование", (TextBox1.Text));
                sqlCmd.ExecuteNonQuery();
                Close();
            }
            else
            {
                FormError f = new FormError();
                FormError.TextError = "Не введена специальность !";
                f.ShowDialog();
            }
        }

        // Отмена
        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Ограничение ввода
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!Char.IsDigit(e.KeyChar)) return;
            //else
            //    e.Handled = true;
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '-')
            {
                e.Handled = true;
            }
        }
    }
}
