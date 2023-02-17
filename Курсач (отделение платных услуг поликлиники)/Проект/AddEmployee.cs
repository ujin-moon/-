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
    public partial class AddEmployee : MetroFramework.Forms.MetroForm
    {
        public AddEmployee()
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

        // Выбор специальности
        int IdS;
        string TitleS;
        private void Button3_Click(object sender, EventArgs e)
        {
            ChooseSpecialty f = new ChooseSpecialty();
            f.ShowDialog();
            IdS = ChooseSpecialty.id;
            TitleS = ChooseSpecialty.Title;
            if (IdS > 0)
            {
                Button3.Text = "Изменить";
                TextBox4.Text = TitleS;
            }
        }

        // Выбор категории врача
        int IdKat;
        string TitleKat;
        private void Button4_Click(object sender, EventArgs e)
        {
            ChooseDoctorСategory f = new ChooseDoctorСategory();
            f.ShowDialog();
            IdKat = ChooseDoctorСategory.id;
            TitleKat = ChooseDoctorСategory.Title;
            if (IdKat > 0)
            {
                Button4.Text = "Изменить";
                TextBox5.Text = TitleKat;
            }
        }

        // Сохранить
        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.TextLength > 0 && TextBox2.TextLength > 0 && TextBox3.TextLength > 0
                && TextBox4.TextLength > 0 && TextBox5.TextLength > 0 && TextBox6.TextLength > 0
                && TextBox8.TextLength > 0 && TextBox8.TextLength > 0)
            {
                string Key = "GFdsg35Gefhr465FD";
                string PasswordCipher = EncryptionClass.Encrypt(TextBox8.Text, Key);
                var sqlCmd = new SqlCommand("AddEmployee", SC);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ID_Специальности", (IdS));
                sqlCmd.Parameters.AddWithValue("@ID_Категории", (IdKat));
                sqlCmd.Parameters.AddWithValue("@Фамилия", (TextBox1.Text));
                sqlCmd.Parameters.AddWithValue("@Имя", (TextBox2.Text));
                sqlCmd.Parameters.AddWithValue("@Отчество", (TextBox3.Text));
                sqlCmd.Parameters.AddWithValue("@Телефон", (TextBox6.Text));
                sqlCmd.Parameters.AddWithValue("@Логин", (TextBox7.Text));
                sqlCmd.Parameters.AddWithValue("@Пароль", (PasswordCipher));
                sqlCmd.Parameters.AddWithValue("@Полномочия", (ComboBox9.Text));
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
            ChooseSpecialty.id = 0;
            ChooseDoctorСategory.id = 0;
            ChooseSpecialty.Title = "";
            ChooseDoctorСategory.Title = "";
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
    }
}
