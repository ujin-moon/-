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
    public partial class EditingPatient : MetroFramework.Forms.MetroForm
    {
        public EditingPatient()
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
        static public int IDp;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.TextLength > 0 && TextBox2.TextLength > 0 && TextBox3.TextLength > 0
                && TextBox4.TextLength > 0 && TextBox6.TextLength > 0 && TextBox7.TextLength > 0
                && TextBox8.TextLength > 0)
            {
                var sqlCmd = new SqlCommand("EditingPatient", SC);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ID_Пациента", (IDp));
                sqlCmd.Parameters.AddWithValue("@Фамилия", (TextBox1.Text));
                sqlCmd.Parameters.AddWithValue("@Имя", (TextBox2.Text));
                sqlCmd.Parameters.AddWithValue("@Отчество", (TextBox3.Text));
                sqlCmd.Parameters.AddWithValue("@ГодРождения", (TextBox4.Text));
                sqlCmd.Parameters.AddWithValue("@Пол", (ComboBox5.Text));
                sqlCmd.Parameters.AddWithValue("@Адрес", (TextBox6.Text));
                sqlCmd.Parameters.AddWithValue("@Телефон", (TextBox7.Text));
                sqlCmd.Parameters.AddWithValue("@ПаспортныеДанные", (TextBox8.Text));
                sqlCmd.ExecuteNonQuery();
                Close();
            }
            else
            {
                FormError f = new FormError();
                FormError.TextError = "Заполнены не все обязательные поля !";
                f.ShowDialog();
            }
        }

        // Отмена
        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Запрет на ввод цифр
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        // Запрет на ввод цифр
        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        // Запрет на ввод цифр
        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        // Ввод только цифр
        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
