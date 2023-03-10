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
    public partial class EditingDoctorWorkSchedule : MetroFramework.Forms.MetroForm
    {
        public EditingDoctorWorkSchedule()
        {
            InitializeComponent();
        }

        // Подключение
        SqlConnection SC;
        static public int IDg;
        private void Add_Shown(object sender, EventArgs e)
        {
            ConnectionClass z = new ConnectionClass();
            SC = z.ConnectBD();
            SC.Open();
            Button3.Text = "Изменить";
            Button4.Text = "Изменить";
        }

        // Выбор врача
        static public int idVr;
        string TitleVr;
        private void Button3_Click(object sender, EventArgs e)
        {
            ChooseDoctor f = new ChooseDoctor();
            f.ShowDialog();
            idVr = ChooseDoctor.id;
            TitleVr = ChooseDoctor.Title;
            if (idVr > 0)
            {
                Button3.Text = "Изменить";
                TextBox1.Text = TitleVr;
            }
        }

        // Выбор вида графика
        static public int idVid;
        string TitleVid;
        private void Button4_Click(object sender, EventArgs e)
        {
            ChoiceChartView f = new ChoiceChartView();
            f.ShowDialog();
            idVid = ChoiceChartView.id;
            TitleVid = ChoiceChartView.Title;
            if (idVid > 0)
            {
                Button4.Text = "Изменить";
                TextBox2.Text = TitleVid;
            }
        }

        // Сохранить
        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.TextLength > 0 && TextBox2.TextLength > 0 && TextBox4.TextLength > 0)
            {
                var sqlCmd = new SqlCommand("EditingDoctorWorkSchedule", SC);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ID_Графика", (IDg));
                sqlCmd.Parameters.AddWithValue("@ID_Сотрудника", (idVr));
                sqlCmd.Parameters.AddWithValue("@ID_ВидаГрафика", (idVid));
                sqlCmd.Parameters.AddWithValue("@Дата", (DateTimePicker1.Value));
                sqlCmd.Parameters.AddWithValue("@Кабинет", (TextBox4.Text));
                sqlCmd.ExecuteNonQuery();
                Close();
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
            ChoiceChartView.id = 0;
            ChooseDoctor.id = 0;
            ChoiceChartView.Title = "";
            ChooseDoctor.Title = "";
            Close();
        }

        // Ограничение ввода кабинета
        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
