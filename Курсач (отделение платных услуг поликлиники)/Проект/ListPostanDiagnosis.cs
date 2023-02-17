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
    public partial class ListPostanDiagnosis : Form
    {
        public ListPostanDiagnosis()
        {
            InitializeComponent();
        }

        //Подключение
        SqlConnection SC;
        public int idUser;
        private void List_Shown(object sender, EventArgs e)
        {
            ConnectionClass z = new ConnectionClass();
            SC = z.ConnectBD();
            SC.Open();
            idUser = FormAuthorization.idUser;
            UpdateTable();
        }

        // Обновление
        private void UpdateTable()
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PrintDoctorVisitNO", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.SelectCommand.Parameters.Add(new SqlParameter("@ID_Сотрудника", SqlDbType.Int));
            da.SelectCommand.Parameters["@ID_Сотрудника"].Value = idUser;
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
            dtUniversal.Columns[1].Visible = false;
            dtUniversal.Columns[2].Visible = false;
            dtUniversal.Columns[3].Visible = false;
            dtUniversal.Columns[4].Visible = false;
            ClickUpdateTable();
        }

        // Обновление истории болезни пациента
        int PachIndex;
        private void ClickUpdateTable()
        {
            if(dtUniversal.Rows.Count > 0)
            {
                // Получение ID_Пациента
                try { PachIndex = dtUniversal.CurrentRow.Index; }
                catch (System.NullReferenceException) { PachIndex = 0; }
                int IDPach = Convert.ToInt32(dtUniversal[4, PachIndex].Value);

                // Поставленные диагнозы
                DataTable dt = new DataTable();
                SqlCommand myCmd = new SqlCommand("PrintTheDiagnosis", SC);
                myCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.SelectCommand.Parameters.Add(new SqlParameter("@ID_Пациента", SqlDbType.Int));
                da.SelectCommand.Parameters["@ID_Пациента"].Value = IDPach;
                da.Fill(dt);
                dtUniversal2.DataSource = dt;
                dtUniversal2.Columns[0].Visible = false;

                // Оказанные услуги
                DataTable dt1 = new DataTable();
                SqlCommand myCmd1 = new SqlCommand("PrintRenderService", SC);
                myCmd1.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da1 = new SqlDataAdapter(myCmd1);
                da1.SelectCommand.Parameters.Add(new SqlParameter("@ID_Пациента", SqlDbType.Int));
                da1.SelectCommand.Parameters["@ID_Пациента"].Value = IDPach;
                da1.Fill(dt1);
                dtUniversal3.DataSource = dt1;
                dtUniversal3.Columns[0].Visible = false;

                // Назначенные лекарства
                DataTable dt2 = new DataTable();
                SqlCommand myCmd2 = new SqlCommand("PrintPrescribedMedications", SC);
                myCmd2.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da2 = new SqlDataAdapter(myCmd2);
                da2.SelectCommand.Parameters.Add(new SqlParameter("@ID_Пациента", SqlDbType.Int));
                da2.SelectCommand.Parameters["@ID_Пациента"].Value = IDPach;
                da2.Fill(dt2);
                dtUniversal4.DataSource = dt2;
                dtUniversal4.Columns[0].Visible = false;
            }
        }

        // История болезни
        private void dtUniversal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickUpdateTable();
        }

        // История болезни
        private void dtUniversal_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClickUpdateTable();
        }

        // Постановка диагноза
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                try { indeks = dtUniversal.CurrentRow.Index; }
                catch (System.NullReferenceException) { indeks = 0; }
                ListNazDiagnosis.idPos = Convert.ToInt32(dtUniversal[0, indeks].Value);
                ListNazDiagnosis f = new ListNazDiagnosis();
                f.ShowDialog();
                PoiskTextBox.Text = "";
                UpdateTable();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Таблица записанных пациентов пуста !";
                f.ShowDialog();
            }
        }

        // Выполненные услуги
        int indeks;
        private void EddButton_Click(object sender, EventArgs e)
        {
            try
            {
                try { indeks = dtUniversal.CurrentRow.Index; }
                catch (System.NullReferenceException) { indeks = 0; }
                ListNazServices.idPos = Convert.ToInt32(dtUniversal[0, indeks].Value);
                ListNazServices f = new ListNazServices();
                f.ShowDialog();
                PoiskTextBox.Text = "";
                UpdateTable();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Таблица записанных пациентов пуста !";
                f.ShowDialog();
            }
        }

        // Назначение лекарств
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                try { indeks = dtUniversal.CurrentRow.Index; }
                catch (System.NullReferenceException) { indeks = 0; }
                ListNazMedicine.idPos = Convert.ToInt32(dtUniversal[0, indeks].Value);
                ListNazMedicine f = new ListNazMedicine();
                f.ShowDialog();
                PoiskTextBox.Text = "";
                UpdateTable();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Таблица записанных пациентов пуста !";
                f.ShowDialog();
            }
        }

        // Поиск
        private void PoiskTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PoiskDoctorVisitNO", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.SelectCommand.Parameters.Add(new SqlParameter("@ID_Сотрудника", SqlDbType.Int));
            da.SelectCommand.Parameters["@ID_Сотрудника"].Value = idUser;
            da.SelectCommand.Parameters.Add(new SqlParameter("@Поиск", SqlDbType.VarChar, 150));
            da.SelectCommand.Parameters["@Поиск"].Value = PoiskTextBox.Text;
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
            dtUniversal.Columns[1].Visible = false;
            dtUniversal.Columns[2].Visible = false;
            dtUniversal.Columns[3].Visible = false;
            dtUniversal.Columns[4].Visible = false;
            ClickUpdateTable();
        }
    }
}
