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
    public partial class AddDiagnosis : MetroFramework.Forms.MetroForm
    {
        public AddDiagnosis()
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

        // Выбор категории диагноза
        int idVr;
        string TitleVr;
        private void Button3_Click(object sender, EventArgs e)
        {
            ChooseCategoryDiagnos f = new ChooseCategoryDiagnos();
            f.ShowDialog();
            idVr = ChooseCategoryDiagnos.id;
            TitleVr = ChooseCategoryDiagnos.Title;
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
                var sqlCmd = new SqlCommand("AddDiagnosis", SC);
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
            ChooseCategoryDiagnos.id = 0;
            ChooseCategoryDiagnos.Title = "";
            Close();
        }

        // Ограничение ввода
        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
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
