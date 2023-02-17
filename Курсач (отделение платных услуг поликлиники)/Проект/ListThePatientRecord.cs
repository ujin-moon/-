using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Проект
{
    public partial class ListThePatientRecord : Form
    {
        public ListThePatientRecord()
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
            if (ToggleSwitch1.Checked == true)
            {
                FilterTable();
            }
            else if (ToggleSwitch1.Checked == false)
            {
                UpdateTable();
            }
        }

        // Обновление
        private void UpdateTable()
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PrintDoctorVisit3", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
            dtUniversal.Columns[1].Visible = false;
            dtUniversal.Columns[2].Visible = false;
            dtUniversal.Columns[3].Visible = false;
            dtUniversal.Columns[4].Visible = false;
            dtUniversal.Columns[14].Visible = false;
        }

        // Добавить
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddThePatientRecord f = new AddThePatientRecord();
            f.ShowDialog();
            PoiskTextBox.Text = "";
            UpdateTable();
        }

        // Редактировать
        private void EddButton_Click(object sender, EventArgs e)
        {
            try
            {
                int indeks;
                try { indeks = dtUniversal.CurrentRow.Index; }
                catch (System.NullReferenceException) { indeks = 0; }
                EditingThePatientRecord f = new EditingThePatientRecord();
                EditingThePatientRecord.IDg = Convert.ToInt32(dtUniversal[0, indeks].Value);
                EditingThePatientRecord.idP = Convert.ToInt32(dtUniversal[4, indeks].Value);
                f.TextBox2.Text = dtUniversal[6, indeks].Value.ToString();
                f.ShowDialog();
                PoiskTextBox.Text = "";
                if (ToggleSwitch1.Checked == true)
                {
                    FilterTable();
                }
                else if (ToggleSwitch1.Checked == false)
                {
                    UpdateTable();
                }
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
                    var sqlCmd = new SqlCommand("DeleteDoctorVisit", SC);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ID_Посещения", Convert.ToInt32(dtUniversal[0, indeks].Value));
                    sqlCmd.ExecuteNonQuery();
                    PoiskTextBox.Text = "";
                    if (ToggleSwitch1.Checked == true)
                    {
                        FilterTable();
                    }
                    else if (ToggleSwitch1.Checked == false)
                    {
                        UpdateTable();
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Таблица записанных пациентов пуста !";
                f.ShowDialog();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                FormError f = new FormError();
                FormError.TextError = "Запись пациента не может быть удалена," + '\n' + "так как уже используется !";
                f.ShowDialog();
            }
        }

        // Поиск
        private void PoiskTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch1.Checked == true)
            {
                DataTable dt = new DataTable();
                SqlCommand myCmd = new SqlCommand("FilterPoiskDoctorVisit3", SC);
                myCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.SelectCommand.Parameters.Add(new SqlParameter("@Поиск", SqlDbType.VarChar, 150));
                da.SelectCommand.Parameters["@Поиск"].Value = PoiskTextBox.Text;
                da.Fill(dt);
                dtUniversal.DataSource = dt;
                dtUniversal.Columns[0].Visible = false;
                dtUniversal.Columns[1].Visible = false;
                dtUniversal.Columns[2].Visible = false;
                dtUniversal.Columns[3].Visible = false;
                dtUniversal.Columns[4].Visible = false;
                dtUniversal.Columns[14].Visible = false;
            }
            else if (ToggleSwitch1.Checked == false)
            {
                DataTable dt = new DataTable();
                SqlCommand myCmd = new SqlCommand("PoiskDoctorVisit3", SC);
                myCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(myCmd);
                da.SelectCommand.Parameters.Add(new SqlParameter("@Поиск", SqlDbType.VarChar, 150));
                da.SelectCommand.Parameters["@Поиск"].Value = PoiskTextBox.Text;
                da.Fill(dt);
                dtUniversal.DataSource = dt;
                dtUniversal.Columns[0].Visible = false;
                dtUniversal.Columns[1].Visible = false;
                dtUniversal.Columns[2].Visible = false;
                dtUniversal.Columns[3].Visible = false;
                dtUniversal.Columns[4].Visible = false;
                dtUniversal.Columns[14].Visible = false;
            }
        }

        // Печать талона в Word
        private readonly string TemplaterFileName = Application.StartupPath.ToString() + @"\ШаблонТалона.docx";
        private void ButtonP1_Click(object sender, EventArgs e)
        {
            ButtonP1.Enabled = false;
            int indeks;
            try { indeks = dtUniversal.CurrentRow.Index; }
            catch (System.NullReferenceException) { indeks = 0; }
            try
            {
                DateTime now = Convert.ToDateTime(dtUniversal[9, indeks].Value);
                var wordapp = new Word.Application();
                var wordDocument = wordapp.Documents.Open(TemplaterFileName);
                wordapp.Visible = false;
                ReplaceWordStub("<Номер_Талона>", dtUniversal[0, indeks].Value.ToString(), wordDocument);
                ReplaceWordStub("<ФИО_Пациента>", dtUniversal[6, indeks].Value.ToString(), wordDocument);
                ReplaceWordStub("<Дата_Приёма>", now.ToString("D"), wordDocument);
                ReplaceWordStub("<Время_Приёма>", dtUniversal[11, indeks].Value.ToString(), wordDocument);
                ReplaceWordStub("<Специальность>", dtUniversal[5, indeks].Value.ToString(), wordDocument);
                ReplaceWordStub("<ФИО_Врача>", dtUniversal[8, indeks].Value.ToString(), wordDocument);
                ReplaceWordStub("<Телефон>", dtUniversal[14, indeks].Value.ToString(), wordDocument);
                ReplaceWordStub("<Кабинет>", dtUniversal[10, indeks].Value.ToString(), wordDocument);
                string path = string.Empty;
                string temp = "";
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        path = saveDialog.FileName;
                        temp = path + " (Талон)";
                        try { wordDocument.SaveAs(temp); } catch (System.Runtime.InteropServices.COMException) { }
                        wordapp.Quit();
                    }
                    else
                    {
                        wordDocument.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                    }
                }
                //wordapp.Quit();
                ButtonP1.Enabled = true;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Таблица записанных пациентов пуста !";
                f.ShowDialog();
                ButtonP1.Enabled = true;
            }
        }

        // Печать акта в Word
        private readonly string TemplaterFileName1 = Application.StartupPath.ToString() + @"\ШаблонАкта.docx";
        private void ButtonP2_Click(object sender, EventArgs e)
        {
            ButtonP2.Enabled = false;
            int indeks;
            try { indeks = dtUniversal.CurrentRow.Index; }
            catch (System.NullReferenceException) { indeks = 0; }
            try
            {
                if(dtUniversal[13, indeks].Value.ToString() != "Ожидается приём")
                {
                    int idPos = Convert.ToInt32(dtUniversal[0, indeks].Value);
                    UpdateTable1(idPos);
                    UpdateTable2(idPos);
                    UpdateTable3(idPos);

                    // Заглушки
                    DateTime now = Convert.ToDateTime(dtUniversal[9, indeks].Value);
                    var wordapp = new Word.Application();
                    var wordDocument = wordapp.Documents.Open(TemplaterFileName1);
                    wordapp.Visible = false;
                    ReplaceWordStub("<Системная_Дата>", DateTime.Now.ToString("D"), wordDocument);
                    ReplaceWordStub("<ID_Посещения>", dtUniversal[0, indeks].Value.ToString(), wordDocument);
                    ReplaceWordStub("<Специальность>", dtUniversal[5, indeks].Value.ToString(), wordDocument);
                    ReplaceWordStub("<ФИО_Врача>", dtUniversal[8, indeks].Value.ToString(), wordDocument);
                    ReplaceWordStub("<ФИО_Пациента>", dtUniversal[6, indeks].Value.ToString(), wordDocument);
                    ReplaceWordStub("<№_Паспорта>", dtUniversal[7, indeks].Value.ToString(), wordDocument);
                    string a = dtUniversal[12, indeks].Value.ToString();
                    string b = a.Replace('.', ','); a = b.Replace(" ", "");
                    ReplaceWordStub("<ИС>", a, wordDocument);

                    // Таблица диагнозов
                    Word.Table poltb = wordDocument.Tables[1];
                    int rows = dtUniversal2.Rows.Count;
                    for (int i = 0; i < rows; i++)
                    {
                        Object oMissing = System.Reflection.Missing.Value;
                        poltb.Rows.Add(ref oMissing);
                    }
                    for (int i = 2; i < dtUniversal2.Rows.Count + 2; i++)
                    {
                        poltb.Cell(i, 1).Range.Text = dtUniversal2.Rows[i - 2].Cells[4].Value + "\t";
                        poltb.Cell(i, 1).Range.Bold = 0;
                        poltb.Cell(i, 2).Range.Text = dtUniversal2.Rows[i - 2].Cells[5].Value + "\t";
                        poltb.Cell(i, 2).Range.Bold = 0;
                    }

                    // Таблица лекарств
                    Word.Table poltb2 = wordDocument.Tables[2];
                    int rows2 = dtUniversal3.Rows.Count;
                    for (int i = 0; i < rows2; i++)
                    {
                        Object oMissing = System.Reflection.Missing.Value;
                        poltb2.Rows.Add(ref oMissing);
                    }
                    for (int i = 2; i < dtUniversal3.Rows.Count + 2; i++)
                    {
                        poltb2.Cell(i, 1).Range.Text = dtUniversal3.Rows[i - 2].Cells[5].Value + "\t";
                        poltb2.Cell(i, 1).Range.Bold = 0;
                        poltb2.Cell(i, 2).Range.Text = dtUniversal3.Rows[i - 2].Cells[6].Value + "\t";
                        poltb2.Cell(i, 2).Range.Bold = 0;
                    }

                    // Таблица услуг
                    Word.Table poltb3 = wordDocument.Tables[3];
                    int rows3 = dtUniversal4.Rows.Count;
                    for (int i = 0; i < rows3; i++)
                    {
                        Object oMissing = System.Reflection.Missing.Value;
                        poltb3.Rows.Add(ref oMissing);
                    }
                    for (int i = 2; i < dtUniversal4.Rows.Count + 2; i++)
                    {
                        string x = dtUniversal4.Rows[i - 2].Cells[4].Value.ToString();
                        int len = x.Length - 2;
                        x = x.Substring(0, len);
                        poltb3.Cell(i, 1).Range.Text = dtUniversal4.Rows[i - 2].Cells[3].Value + "\t";
                        poltb3.Cell(i, 1).Range.Bold = 0;
                        poltb3.Cell(i, 2).Range.Text = x + "\t";
                        poltb3.Cell(i, 2).Range.Bold = 0;
                    }

                    // Сохранение
                    string path = string.Empty;
                    string temp = "";
                    using (SaveFileDialog saveDialog = new SaveFileDialog())
                    {
                        if (saveDialog.ShowDialog() == DialogResult.OK)
                        {
                            path = saveDialog.FileName;
                            temp = path + " (АКТ)";
                            try { wordDocument.SaveAs(temp); } catch (System.Runtime.InteropServices.COMException) { }
                            wordapp.Quit();

                            string Statys = dtUniversal[13, indeks].Value.ToString();
                            if (Statys == "Ожидается оплата")
                            {
                                var sqlCmd = new SqlCommand("AddRedStatus", SC);
                                sqlCmd.CommandType = CommandType.StoredProcedure;
                                sqlCmd.Parameters.AddWithValue("@ID_Посещения", idPos);
                                sqlCmd.Parameters.AddWithValue("@Статус", "Оплачено");
                                sqlCmd.ExecuteNonQuery();
                                UpdateTable();
                            }
                        }
                        else
                        {
                            wordDocument.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                        }
                    }
                    //wordapp.Quit();
                    ButtonP2.Enabled = true;
                }
                else if (dtUniversal[13, indeks].Value.ToString() == "Ожидается приём")
                {
                    FormError f = new FormError();
                    FormError.TextError = "Акт выполненных работ не может быть" + '\n' + "сформирован," +
                        " так как ожидается приём!";
                    f.ShowDialog();
                    ButtonP2.Enabled = true;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FormError f = new FormError();
                FormError.TextError = "Таблица записанных пациентов пуста !";
                f.ShowDialog();
                ButtonP2.Enabled = true;
            }
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        // Фильтр по дате
        private void FilterTable()
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("FilterPrintDoctorVisit3", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.SelectCommand.Parameters.Add(new SqlParameter("@Дата", SqlDbType.Date));
            da.SelectCommand.Parameters["@Дата"].Value = Convert.ToDateTime(DateTimePicker1.Value);
            da.Fill(dt);
            dtUniversal.DataSource = dt;
            dtUniversal.Columns[0].Visible = false;
            dtUniversal.Columns[1].Visible = false;
            dtUniversal.Columns[2].Visible = false;
            dtUniversal.Columns[3].Visible = false;
            dtUniversal.Columns[4].Visible = false;
            dtUniversal.Columns[14].Visible = false;
        }

        // Включить/выключить фильтр
        private void ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch1.Checked == true)
            {
                FilterTable();
            }
            else if (ToggleSwitch1.Checked == false)
            {
                UpdateTable();
            }
        }

        // Фильтр при изменении даты
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch1.Checked == true)
            {
                FilterTable();
            }
        }

        // Диагнозы
        private void UpdateTable1(int idPos)
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PrintNazDiagnosis", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.SelectCommand.Parameters.Add(new SqlParameter("@ID_Посещения", SqlDbType.Int));
            da.SelectCommand.Parameters["@ID_Посещения"].Value = idPos;
            da.Fill(dt);
            dtUniversal2.DataSource = dt;
            dtUniversal2.Columns[0].Visible = false;
            dtUniversal2.Columns[1].Visible = false;
            dtUniversal2.Columns[2].Visible = false;
            dtUniversal2.Columns[3].Visible = false;
        }


        // Лекарства
        private void UpdateTable2(int idPos)
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PrintAppointment", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.SelectCommand.Parameters.Add(new SqlParameter("@ID_Посещения", SqlDbType.Int));
            da.SelectCommand.Parameters["@ID_Посещения"].Value = idPos;
            da.Fill(dt);
            dtUniversal3.DataSource = dt;
            dtUniversal3.Columns[0].Visible = false;
            dtUniversal3.Columns[1].Visible = false;
            dtUniversal3.Columns[2].Visible = false;
            dtUniversal3.Columns[3].Visible = false;
        }

        // Услуги
        private void UpdateTable3(int idPos)
        {
            DataTable dt = new DataTable();
            SqlCommand myCmd = new SqlCommand("PrintNazServices", SC);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.SelectCommand.Parameters.Add(new SqlParameter("@ID_Посещения", SqlDbType.Int));
            da.SelectCommand.Parameters["@ID_Посещения"].Value = idPos;
            da.Fill(dt);
            dtUniversal4.DataSource = dt;
            dtUniversal4.Columns[0].Visible = false;
            dtUniversal4.Columns[1].Visible = false;
            dtUniversal4.Columns[2].Visible = false;
        }
    }
}
