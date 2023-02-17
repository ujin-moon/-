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
    public partial class AddMedicine : MetroFramework.Forms.MetroForm
    {
        public AddMedicine()
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

        // Выбор категории лекарства
        int idVr;
        string TitleVr;
        private void Button3_Click(object sender, EventArgs e)
        {
            ChooseCategoryMedicine f = new ChooseCategoryMedicine();
            f.ShowDialog();
            idVr = ChooseCategoryMedicine.id;
            TitleVr = ChooseCategoryMedicine.Title;
            if (idVr > 0)
            {
                Button3.Text = "Изменить";
                TextBox1.Text = TitleVr;
            }
        }

        // Сохранить
        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.TextLength > 0 && TextBox2.TextLength > 0)
            {
                var sqlCmd = new SqlCommand("AddMedicine", SC);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ID_Категории", (idVr));
                sqlCmd.Parameters.AddWithValue("@Наименование", (TextBox2.Text));
                sqlCmd.ExecuteNonQuery();
                Close();
            }
            else
            {
                FormError f = new FormError();
                FormError.TextError = "Не все поля заполнены !";
                f.ShowDialog();
            }
        }

        // Отмена
        private void Button2_Click(object sender, EventArgs e)
        {
            ChooseCategoryMedicine.id = 0;
            ChooseCategoryMedicine.Title = "";
            Close();
        }

        // Ограничение ввода
        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (Char.IsDigit(l)) return;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '-')
            {
                e.Handled = true;
            }
        }
    }
}
