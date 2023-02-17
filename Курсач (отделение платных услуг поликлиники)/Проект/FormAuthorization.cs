using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Проект
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        // Подключение
        SqlConnection SC;
        private void FormAuthorization_Shown(object sender, EventArgs e)
        {
            ConnectionClass z = new ConnectionClass();
            SC = z.ConnectBD();
        }

        static public int idUser;
        public void AuthorizationBD()
        {
            string LoginUser = "";
            string PasswordUser = "";
            string Authority = "";
            string FUser = "";
            string IUser = "";
            string Key = "GFdsg35Gefhr465FD";
            string Login = LoginTextBox.Text;
            string Password = PasswordTextBox.Text;
            SC.Open();
            using (SqlCommand command = SC.CreateCommand())
            {
                command.CommandText = string.Format(@"SELECT ID_Пользователя, Логин, Пароль, Полномочия, Фамилия, Имя FROM Пользователь WHERE Логин = '" + Login + "'", SC);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (Password == EncryptionClass.Decrypt(reader[2].ToString(), Key))
                    {
                        idUser = Convert.ToInt32(reader[0]);
                        LoginUser = reader[1].ToString();
                        PasswordUser = reader[2].ToString();
                        Authority = reader[3].ToString();
                        FUser = reader[4].ToString();
                        IUser = reader[5].ToString();
                    }
                }
                reader.Close();
            }
            SC.Close();

            if (PasswordUser.Length > 0)
            {
                PasswordUser = EncryptionClass.Decrypt(PasswordUser, Key);
                if (Login == LoginUser && Password == PasswordUser)
                {
                    if (Authority == "Администратор")
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            Thread.Sleep(60);
                            this.Opacity = this.Opacity - 0.1;
                        }
                        Hide();
                        FormAdministrator f = new FormAdministrator();
                        f.FIOLabel.Text = FUser + "\n" + IUser;
                        f.RoleLabel.Text = Authority;
                        f.ShowDialog();
                        this.Close();
                    }
                    else if (Authority == "Регистратор")
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            Thread.Sleep(60);
                            this.Opacity = this.Opacity - 0.1;
                        }
                        Hide();
                        FormRegistrar f = new FormRegistrar();
                        f.FIOLabel.Text = FUser + "\n" + IUser;
                        f.RoleLabel.Text = Authority;
                        f.ShowDialog();
                        this.Close();
                    }
                    else if (Authority == "Врач")
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            Thread.Sleep(60);
                            this.Opacity = this.Opacity - 0.1;
                        }
                        Hide();
                        FormDoctor f = new FormDoctor();
                        f.FIOLabel.Text = FUser + "\n" + IUser;
                        f.RoleLabel.Text = Authority;
                        f.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    ErrorMessage("Неверный логин или пароль!");
                }
            }
            else
            {
                ErrorMessage("Неверный логин или пароль!");
            }
        }

        // Ошибки
        private void ErrorMessage(string Text)
        {
            ErrorIcon.Visible = true;
            ErrorMessageTB.Visible = true;
            ErrorMessageTB.Text = Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AuthorizationBD();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Авторизация по нажатию кнопки Enter
        private void FormAuthorization_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                Button1_Click(guna2Button1, null);
            }
        }
    }
}
