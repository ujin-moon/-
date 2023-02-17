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
    public partial class AddThePatientRecord1 : MetroFramework.Forms.MetroForm
    {
        public AddThePatientRecord1()
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

        // Выбор врача и даты
        int idVD;
        string TitleVD;
        DateTime Time1;
        DateTime Time2;
        private void Button3_Click(object sender, EventArgs e)
        {
            ChooseDoctorDate f = new ChooseDoctorDate();
            f.ShowDialog();
            idVD = ChooseDoctorDate.id;
            TitleVD = ChooseDoctorDate.Title;
            Time1 = Convert.ToDateTime(ChooseDoctorDate.Time1);
            Time2 = Convert.ToDateTime(ChooseDoctorDate.Time2);
            if (idVD > 0)
            {
                Button3.Text = "Изменить";
                TextBox1.Text = TitleVD;
            }
        }

        // Сформировать
        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.TextLength > 0)
            {
                try
                {
                    while (Time1 < Time2)
                    {
                        var sqlCmd = new SqlCommand("AddDoctorVisit2", SC);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ID_Графика", (idVD));
                        sqlCmd.Parameters.AddWithValue("@ВремяПриёма", (Time1.ToShortTimeString()));
                        sqlCmd.Parameters.AddWithValue("@ОбщаяСтоимость", (0));
                        sqlCmd.Parameters.AddWithValue("@Статус", ("Ожидается приём"));
                        sqlCmd.ExecuteNonQuery();
                        Time1 = Time1.AddMinutes(15);
                    }
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
                FormError.TextError = "Не выбран график работы !";
                f.ShowDialog();
            }
        }

        // Отмена
        private void Button2_Click(object sender, EventArgs e)
        {
            ChooseDoctorDate.id = 0;
            ChooseDoctorDate.Title = "";
            Close();
        }
    }
}
