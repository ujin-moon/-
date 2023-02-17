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
    public partial class AddChartView : MetroFramework.Forms.MetroForm
    {
        public AddChartView()
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

        // Сохранить
        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.TextLength > 0 && TextBox2.TextLength > 0)
            {
                try
                {
                    var sqlCmd = new SqlCommand("AddChartView", SC);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ВремяНачала", (maskedTextBox1.Text));
                    sqlCmd.Parameters.AddWithValue("@ВремяОкончания", (maskedTextBox2.Text));
                    sqlCmd.ExecuteNonQuery();
                    Close();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    FormError f = new FormError();
                    FormError.TextError = "Введено некорректное время !";
                    f.ShowDialog();
                }
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
            Close();
        }

        // Маска
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBox1.TextLength > 0)
            {
                maskedTextBox1.Visible = true;
                maskedTextBox1.Focus();
                maskedTextBox1.Text = TextBox1.Text;
                TextBox1.Enabled = false;
            }
        }

        // Маска
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (TextBox2.TextLength > 0)
            {
                maskedTextBox2.Visible = true;
                maskedTextBox2.Focus();
                maskedTextBox2.Text = TextBox1.Text;
                TextBox2.Enabled = false;
            }
        }
    }
}
