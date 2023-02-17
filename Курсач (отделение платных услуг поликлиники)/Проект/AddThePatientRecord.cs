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
    public partial class AddThePatientRecord : MetroFramework.Forms.MetroForm
    {
        public AddThePatientRecord()
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

        // Выбор талона
        int idVD;
        string TitleVD;
        private void Button3_Click(object sender, EventArgs e)
        {
            ChooseDoctorDate1 f = new ChooseDoctorDate1();
            f.ShowDialog();
            idVD = ChooseDoctorDate1.id;
            TitleVD = ChooseDoctorDate1.Title;
            if (idVD > 0)
            {
                Button3.Text = "Изменить";
                TextBox1.Text = TitleVD;
            }
        }

        // Выбор пациента
        int idP;
        string TitleP;
        private void Button4_Click(object sender, EventArgs e)
        {
            ChoicePatient f = new ChoicePatient();
            f.ShowDialog();
            idP = ChoicePatient.id;
            TitleP = ChoicePatient.Title;
            if (idP > 0)
            {
                Button4.Text = "Изменить";
                TextBox2.Text = TitleP;
            }
        }

        // Сохранить
        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.TextLength > 0 && TextBox2.TextLength > 0)
            {
                try
                {
                    var sqlCmd = new SqlCommand("AddDoctorVisit3", SC);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ID_Посещения", (idVD));
                    sqlCmd.Parameters.AddWithValue("@ID_Пациента", (idP));
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
            ChoicePatient.id = 0;
            ChooseDoctorDate1.id = 0;
            ChoicePatient.Title = "";
            ChooseDoctorDate1.Title = "";
            Close();
        }
    }
}
