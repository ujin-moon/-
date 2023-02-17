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
    public partial class ChooseSpecialty : MetroFramework.Forms.MetroForm
    {
        public ChooseSpecialty()
        {
            InitializeComponent();
        }

        // Подключение
        SqlConnection SC;
        private void Choose_Shown(object sender, EventArgs e)
        {
            ConnectionClass z = new ConnectionClass();
            SC = z.ConnectBD();
            SC.Open();
            UpdateTable();
            PoiskTextBox.MaxLength = 45;
        }

        // Обновление
        private void UpdateTable()
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PrintSpecialty", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
        }

        // Выбрать
        static public int id;
        static public string Title;
        private void Button1_Click(object sender, EventArgs e)
        {
            int indeks;
            try { indeks = dtUniversal.CurrentRow.Index; }
            catch (System.NullReferenceException) { indeks = 0; }
            try
            {
                id = Convert.ToInt32(dtUniversal[0, indeks].Value);
                Title = dtUniversal[1, indeks].Value.ToString();
                Close();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Таблица специальностей пуста !";
                f.ShowDialog();
            }
        }

        // Добавить
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddSpecialty f = new AddSpecialty();
            f.ShowDialog();
            PoiskTextBox.Text = "";
            UpdateTable();
        }

        // Поиск
        private void PoiskTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PoiskSpecialty", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.SelectCommand.Parameters.Add(new SqlParameter("@Наименование", SqlDbType.VarChar, 65));
            da.SelectCommand.Parameters["@Наименование"].Value = PoiskTextBox.Text;
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
        }

        // Отмена
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Запрет на ввод цифр
        private void PoiskTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '-')
            {
                e.Handled = true;
            }
        }
    }
}
