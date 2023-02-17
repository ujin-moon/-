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
    public partial class ChoiceChartView : MetroFramework.Forms.MetroForm
    {
        public ChoiceChartView()
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
            SqlCommand myCmd = new SqlCommand("PrintChartView", SC);
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
                Title = dtUniversal[1, indeks].Value.ToString() + " - " + dtUniversal[2, indeks].Value.ToString();
                Close();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Таблица видов графика пуста !";
                f.ShowDialog();
            }
        }

        // Добавить
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddChartView f = new AddChartView();
            f.ShowDialog();
            PoiskTextBox.Text = "";
            UpdateTable();
        }

        // Поиск
        private void PoiskTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PoiskChartView", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.SelectCommand.Parameters.Add(new SqlParameter("@Поиск", SqlDbType.VarChar, 10));
            da.SelectCommand.Parameters["@Поиск"].Value = PoiskTextBox.Text;
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
        }

        // Отмена
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
