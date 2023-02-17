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
    public partial class ListEmployee : Form
    {
        public ListEmployee()
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

        // Расшифровка пароля
        private void DecryptingPassword()
        {
            string Key = "GFdsg35Gefhr465FD";
            for (int i = 0; i < dtUniversal.Rows.Count; i++)
            {
                string PasswordCipher = EncryptionClass.Decrypt(dtUniversal.Rows[i].Cells[10].Value.ToString(), Key);
                dtUniversal.Rows[i].Cells[10].Value = PasswordCipher;
            }
        }

        // Обновление
        private void UpdateTable()
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PrintEmployee", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            DecryptingPassword();
            dtUniversal.Columns[0].Visible = false;
            dtUniversal.Columns[1].Visible = false;
            dtUniversal.Columns[2].Visible = false;
        }

        // Добавить
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddEmployee f = new AddEmployee();
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
                EditingEmployee f = new EditingEmployee();
                EditingEmployee.IDv = Convert.ToInt32(dtUniversal[0, indeks].Value);
                EditingEmployee.IdS = Convert.ToInt32(dtUniversal[1, indeks].Value);
                EditingEmployee.IdKat = Convert.ToInt32(dtUniversal[2, indeks].Value);
                f.TextBox4.Text = dtUniversal[3, indeks].Value.ToString();
                f.TextBox5.Text = dtUniversal[4, indeks].Value.ToString();
                f.TextBox1.Text = dtUniversal[5, indeks].Value.ToString();
                f.TextBox2.Text = dtUniversal[6, indeks].Value.ToString();
                f.TextBox3.Text = dtUniversal[7, indeks].Value.ToString();
                f.TextBox6.Text = dtUniversal[8, indeks].Value.ToString();
                //string a = dtUniversal[9, indeks].Value.ToString();
                //string b = a.Replace(',', '.');
                //f.TextBox7.Text = b;
                f.TextBox7.Text = dtUniversal[9, indeks].Value.ToString();
                f.TextBox8.Text = dtUniversal[10, indeks].Value.ToString();
                f.ComboBox9.Text = dtUniversal[11, indeks].Value.ToString();
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
                    var sqlCmd = new SqlCommand("DeleteEmployee", SC);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ID_Сотрудника", Convert.ToInt32(dtUniversal[0, indeks].Value));
                    sqlCmd.ExecuteNonQuery();
                    PoiskTextBox.Text = "";
                    UpdateTable();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Таблица сотрудников пуста !";
                f.ShowDialog();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                FormError f = new FormError();
                FormError.TextError = "Сотрудник не может быть удален," + '\n' + "так как уже используется !";
                f.ShowDialog();
            }
        }

        // Поиск
        private void PoiskTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PoiskEmployee", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.SelectCommand.Parameters.Add(new SqlParameter("@Поиск", SqlDbType.VarChar, 40));
            da.SelectCommand.Parameters["@Поиск"].Value = PoiskTextBox.Text;
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            DecryptingPassword();
            dtUniversal.Columns[0].Visible = false;
            dtUniversal.Columns[1].Visible = false;
            dtUniversal.Columns[2].Visible = false;
        }
    }
}
