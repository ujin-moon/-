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
    public partial class ChoiceMedicine : MetroFramework.Forms.MetroForm
    {
        public ChoiceMedicine()
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
        }

        // Обновление
        private void UpdateTable()
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PrintMedicine", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
            dtUniversal.Columns[1].Visible = false;
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
                Title = dtUniversal[3, indeks].Value.ToString();
                Close();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Таблица лекарств пуста !";
                f.ShowDialog();
            }
        }

        // Добавить
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddMedicine f = new AddMedicine();
            f.ShowDialog();
            PoiskTextBox.Text = "";
            UpdateTable();
        }

        // Поиск
        private void PoiskTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PoiskMedicine", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.SelectCommand.Parameters.Add(new SqlParameter("@Поиск", SqlDbType.VarChar, 100));
            da.SelectCommand.Parameters["@Поиск"].Value = PoiskTextBox.Text;
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
            dtUniversal.Columns[1].Visible = false;
        }

        // Отмена
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
