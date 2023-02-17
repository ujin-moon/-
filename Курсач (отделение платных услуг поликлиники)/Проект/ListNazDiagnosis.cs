﻿using System;
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
    public partial class ListNazDiagnosis : MetroFramework.Forms.MetroForm
    {
        public ListNazDiagnosis()
        {
            InitializeComponent();
        }

        //Подключение
        SqlConnection SC;
        static public int idPos;
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
            SqlCommand myCmd = new SqlCommand("PrintNazDiagnosis", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.SelectCommand.Parameters.Add(new SqlParameter("@ID_Посещения", SqlDbType.Int));
            da.SelectCommand.Parameters["@ID_Посещения"].Value = idPos;
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
            AddNazDiagnosis1 f = new AddNazDiagnosis1();
            AddNazDiagnosis1.idPos = idPos;
            f.ShowDialog();
            PoiskTextBox.Text = "";
            UpdateTable();
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
                    var sqlCmd = new SqlCommand("DeletePosDiagnosis", SC);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ID_ПостановкиДиагноза", Convert.ToInt32(dtUniversal[0, indeks].Value));
                    sqlCmd.ExecuteNonQuery();
                    PoiskTextBox.Text = "";
                    UpdateTable();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Таблица назначеных диагнозов пуста !";
                f.ShowDialog();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                FormError f = new FormError();
                FormError.TextError = "Назначенный диагноз не может быть удалён," + '\n' + "так как уже используется !";
                f.ShowDialog();
            }
        }

        // Поиск
        private void PoiskTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PoiskNazDiagnosis", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.SelectCommand.Parameters.Add(new SqlParameter("@Поиск", SqlDbType.VarChar, 100));
            da.SelectCommand.Parameters["@Поиск"].Value = PoiskTextBox.Text;
            da.SelectCommand.Parameters.Add(new SqlParameter("@ID_Посещения", SqlDbType.Int));
            da.SelectCommand.Parameters["@ID_Посещения"].Value = idPos;
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
        }

        // Запрет на ввод цифр
        private void PoiskTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        // Закрыть
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
