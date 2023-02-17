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
    public partial class ListDoctorWorkSchedule : Form
    {
        public ListDoctorWorkSchedule()
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
            SqlCommand myCmd = new SqlCommand("PrintDoctorWorkSchedule", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
            dtUniversal.Columns[1].Visible = false;
            dtUniversal.Columns[2].Visible = false;
        }

        // Добавить
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddDoctorWorkSchedule f = new AddDoctorWorkSchedule();
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
            catch(System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Дата работы не может быть ниже" + '\n' + "текущей даты !";
                f.ShowDialog();
            }
        }

        // Редактировать
        int indeks;
        private void EddButton_Click(object sender, EventArgs e)
        {
            try
            {
                try { indeks = dtUniversal.CurrentRow.Index; }
                catch (System.NullReferenceException) { indeks = 0; }
                EditingDoctorWorkSchedule f = new EditingDoctorWorkSchedule();
                EditingDoctorWorkSchedule.IDg = Convert.ToInt32(dtUniversal[0, indeks].Value);
                EditingDoctorWorkSchedule.idVr = Convert.ToInt32(dtUniversal[1, indeks].Value);
                EditingDoctorWorkSchedule.idVid = Convert.ToInt32(dtUniversal[2, indeks].Value);
                f.TextBox1.Text = dtUniversal[4, indeks].Value.ToString();
                f.DateTimePicker1.Value = Convert.ToDateTime(dtUniversal[5, indeks].Value.ToString());
                f.TextBox2.Text = dtUniversal[6, indeks].Value.ToString() + " - " +
                    dtUniversal[7, indeks].Value.ToString();
                f.TextBox4.Text = dtUniversal[8, indeks].Value.ToString();
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
            catch (System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Таблица графиков работы пуста !";
                f.ShowDialog();
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
                    var sqlCmd = new SqlCommand("DeleteDoctorWorkSchedule", SC);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ID_Графика", Convert.ToInt32(dtUniversal[0, indeks].Value));
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
                FormError.TextError = "Таблица графиков работы врачей пуста !";
                f.ShowDialog();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                FormError f = new FormError();
                FormError.TextError = "График работы не может быть удалена," + '\n' + "так как уже используется !";
                f.ShowDialog();
            }
        }

        // Поиск
        private void PoiskTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch1.Checked == true)
            {
                DataTable dt = new DataTable();
                SqlCommand myCmd = new SqlCommand("PoiskDoctorWorkSchedule1", SC);
                myCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.SelectCommand.Parameters.Add(new SqlParameter("@Поиск", SqlDbType.VarChar, 110));
                da.SelectCommand.Parameters["@Поиск"].Value = PoiskTextBox.Text;
                da.SelectCommand.Parameters.Add(new SqlParameter("@Дата", SqlDbType.Date));
                da.SelectCommand.Parameters["@Дата"].Value = Convert.ToDateTime(DateTimePicker1.Value);
                da.Fill(dt);
                dtUniversal.DataSource = dt;
                dtUniversal.Columns[0].Visible = false;
                dtUniversal.Columns[1].Visible = false;
                dtUniversal.Columns[2].Visible = false;
            }
            else if (ToggleSwitch1.Checked == false)
            {
                DataTable dt = new DataTable();
                SqlCommand myCmd = new SqlCommand("PoiskDoctorWorkSchedule", SC);
                myCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.SelectCommand.Parameters.Add(new SqlParameter("@Поиск", SqlDbType.VarChar, 110));
                da.SelectCommand.Parameters["@Поиск"].Value = PoiskTextBox.Text;
                da.Fill(dt);
                dtUniversal.DataSource = dt;
                dtUniversal.Columns[0].Visible = false;
                dtUniversal.Columns[1].Visible = false;
                dtUniversal.Columns[2].Visible = false;
            }
        }

        // Фильтр по дате
        private void FilterTable()
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("FilterPrintDoctorWorkSchedule", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.SelectCommand.Parameters.Add(new SqlParameter("@Дата", SqlDbType.Date));
            da.SelectCommand.Parameters["@Дата"].Value = Convert.ToDateTime(DateTimePicker1.Value);
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
            dtUniversal.Columns[1].Visible = false;
            dtUniversal.Columns[2].Visible = false;
        }

        // Включить/выключить фильтр
        private void ToggleSwitch1_CheckedChanged_1(object sender, EventArgs e)
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
