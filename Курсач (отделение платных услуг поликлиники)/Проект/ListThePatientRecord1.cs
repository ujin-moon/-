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
    public partial class ListThePatientRecord1 : Form
    {
        public ListThePatientRecord1()
        {
            InitializeComponent();
        }

        //Подключение
        SqlConnection SC;
        private void List_Shown(object sender, EventArgs e)
        {
            ConnectionClass z = new ConnectionClass();
            SC = z.ConnectBD();
            SC.Open();
            if (ToggleSwitch1.Checked == true)
            {
                FilterTable();
            }
            else if (ToggleSwitch1.Checked == false)
            {
                UpdateTable();
            }
        }

        // Обновление
        private void UpdateTable()
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PrintDoctorVisit2", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
            dtUniversal.Columns[1].Visible = false;
            dtUniversal.Columns[2].Visible = false;
            dtUniversal.Columns[3].Visible = false;
        }

        // Добавить
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddThePatientRecord1 f = new AddThePatientRecord1();
            f.ShowDialog();
            PoiskTextBox.Text = "";
            if (ToggleSwitch1.Checked == true)
            {
                FilterTable();
            }
            else if (ToggleSwitch1.Checked == false)
            {
                UpdateTable();
            }
        }

        // Удалить
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int indeks;
            try { indeks = dtUniversal.CurrentRow.Index; }
            catch (System.NullReferenceException) { indeks = 0; }
            try
            {
                FormDelete f = new FormDelete();
                f.ShowDialog();
                bool DeleteBool = FormDelete.DeleteBool;
                if (DeleteBool == true)
                {
                    var sqlCmd = new SqlCommand("DeleteDoctorVisit", SC);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ID_Посещения", Convert.ToInt32(dtUniversal[0, indeks].Value));
                    sqlCmd.ExecuteNonQuery();
                    PoiskTextBox.Text = "";
                    if (ToggleSwitch1.Checked == true)
                    {
                        FilterTable();
                    }
                    else if (ToggleSwitch1.Checked == false)
                    {
                        UpdateTable();
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Таблица времени приёма пуста !";
                f.ShowDialog();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                FormError f = new FormError();
                FormError.TextError = "Время приёма не может быть удалено," + '\n' + "так как уже используется !";
                f.ShowDialog();
            }
        }

        // Поиск
        private void PoiskTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch1.Checked == true)
            {
                DataTable dt = new DataTable();
                SqlCommand myCmd = new SqlCommand("FilerPoiskDoctorVisit2", SC);
                myCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.SelectCommand.Parameters.Add(new SqlParameter("@Поиск", SqlDbType.VarChar, 150));
                da.SelectCommand.Parameters["@Поиск"].Value = PoiskTextBox.Text;
                da.SelectCommand.Parameters.Add(new SqlParameter("@Дата", SqlDbType.Date));
                da.SelectCommand.Parameters["@Дата"].Value = Convert.ToDateTime(DateTimePicker1.Value);
                da.Fill(dt);
                dtUniversal.DataSource = dt;
                dtUniversal.Columns[0].Visible = false;
                dtUniversal.Columns[1].Visible = false;
                dtUniversal.Columns[2].Visible = false;
                dtUniversal.Columns[3].Visible = false;
            }
            else if (ToggleSwitch1.Checked == false)
            {
                DataTable dt = new DataTable();
                SqlCommand myCmd = new SqlCommand("PoiskDoctorVisit2", SC);
                myCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.SelectCommand.Parameters.Add(new SqlParameter("@Поиск", SqlDbType.VarChar, 150));
                da.SelectCommand.Parameters["@Поиск"].Value = PoiskTextBox.Text;
                da.Fill(dt);
                dtUniversal.DataSource = dt;
                dtUniversal.Columns[0].Visible = false;
                dtUniversal.Columns[1].Visible = false;
                dtUniversal.Columns[2].Visible = false;
                dtUniversal.Columns[3].Visible = false;
            }
        }

        // Фильтр по дате
        private void FilterTable()
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("FilterPrintDoctorVisit2", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.SelectCommand.Parameters.Add(new SqlParameter("@Дата", SqlDbType.Date));
            da.SelectCommand.Parameters["@Дата"].Value = Convert.ToDateTime(DateTimePicker1.Value);
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
            dtUniversal.Columns[1].Visible = false;
            dtUniversal.Columns[2].Visible = false;
            dtUniversal.Columns[3].Visible = false;
        }

        // Включить/выключить фильтр
        private void ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch1.Checked == true)
            {
                FilterTable();
            }
            else if (ToggleSwitch1.Checked == false)
            {
                UpdateTable();
            }
        }

        // Фильтр при изменении даты
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch1.Checked == true)
            {
                FilterTable();
            }
        }
    }
}
