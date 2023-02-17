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
    public partial class ListPatient : Form
    {
        public ListPatient()
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
            UpdateTable();
        }

        // Обновление
        private void UpdateTable()
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PrintPatient", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
        }

        // Добавить
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddPatient f = new AddPatient();
            f.ShowDialog();
            PoiskTextBox.Text = "";
            UpdateTable();
        }

        // Редактировать
        int indeks;
        private void EddButton_Click(object sender, EventArgs e)
        {
            try
            {
                try { indeks = dtUniversal.CurrentRow.Index; }
                catch (System.NullReferenceException) { indeks = 0; }
                EditingPatient f = new EditingPatient();
                EditingPatient.IDp = Convert.ToInt32(dtUniversal[0, indeks].Value);
                f.TextBox1.Text = dtUniversal[1, indeks].Value.ToString();
                f.TextBox2.Text = dtUniversal[2, indeks].Value.ToString();
                f.TextBox3.Text = dtUniversal[3, indeks].Value.ToString();
                f.TextBox4.Text = dtUniversal[4, indeks].Value.ToString();
                f.ComboBox5.Text = dtUniversal[5, indeks].Value.ToString();
                f.TextBox6.Text = dtUniversal[6, indeks].Value.ToString();
                f.TextBox7.Text = dtUniversal[7, indeks].Value.ToString();
                f.TextBox8.Text = dtUniversal[8, indeks].Value.ToString();
                f.ShowDialog();
                PoiskTextBox.Text = "";
                UpdateTable();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Таблица сотрудников пуста !";
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
                    var sqlCmd = new SqlCommand("DeletePatient", SC);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ID_Пациента", Convert.ToInt32(dtUniversal[0, indeks].Value));
                    sqlCmd.ExecuteNonQuery();
                    PoiskTextBox.Text = "";
                    UpdateTable();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Таблица пациентов пуста !";
                f.ShowDialog();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                FormError f = new FormError();
                FormError.TextError = "Пациент не может быть удален," + '\n' + "так как уже используется !";
                f.ShowDialog();
            }
        }

        // Поиск
        private void PoiskTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PoiskPatient", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.SelectCommand.Parameters.Add(new SqlParameter("@Поиск", SqlDbType.VarChar, 150));
            da.SelectCommand.Parameters["@Поиск"].Value = PoiskTextBox.Text;
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
        }
    }
}
