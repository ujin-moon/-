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
    public partial class EditingThePatientRecord : MetroFramework.Forms.MetroForm
    {
        public EditingThePatientRecord()
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

        // Выбор пациента
        static public int idP;
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
        static public int IDg;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.TextLength > 0)
            {
                try
                {
                    var sqlCmd = new SqlCommand("AddDoctorVisit3", SC);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ID_Посещения", (IDg));
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
            ChoicePatient.Title = "";
            Close();
        }
    }
}
