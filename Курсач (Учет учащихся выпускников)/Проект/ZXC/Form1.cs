using System;
using System.Windows.Forms;

namespace ZXC
{
    public partial class Form1 : Form
    {
        // Конструктор
        public Form1()
        {
            InitializeComponent();

            // Заполнение таблиц данными
            foreach (string[] row in DB.SELECT.Students())
                dataGridView1.Rows.Add(row);
            foreach (string[] row in DB.SELECT.Rerasp())
                dataGridView2.Rows.Add(row);
            foreach (string[] row in DB.SELECT.Org())
                dataGridView3.Rows.Add(row);
            foreach (string[] row in DB.SELECT.Dist())
                dataGridView4.Rows.Add(row);
            foreach (string[] row in DB.SELECT.Sredstva())
                dataGridView6.Rows.Add(row);
            foreach (string[] row in DB.SELECT.Zay())
                dataGridView5.Rows.Add(row);
            foreach (string[] row in DB.SELECT.Years())
                dataGridView7.Rows.Add(row);
            foreach (string[] row in DB.SELECT.Rasp())
                dataGridView8.Rows.Add(row);
            foreach (string[] row in DB.SELECT.Speciality())
                dataGridView9.Rows.Add(row);
        }


        // Редактирование записи в таблице
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Выпускники
            if (tabControl1.SelectedIndex == 0)
                new AddStudent(ref dataGridView1, true).ShowDialog();
            // Перераспределения
            else if (tabControl1.SelectedIndex == 1)
                new AddRerasp(ref dataGridView2, true).ShowDialog();
            // Организации
            else if (tabControl1.SelectedIndex == 2)
                new AddOrg(ref dataGridView3, true).ShowDialog();
            // Районы
            else if (tabControl1.SelectedIndex == 3)
                new AddDist(ref dataGridView4, true).ShowDialog();
            // Заявки
            else if (tabControl1.SelectedIndex == 4)
                new AddZay(ref dataGridView5, true).ShowDialog();
            // Средства обучения
            else if (tabControl1.SelectedIndex == 5)
                new AddSred(ref dataGridView6, true).ShowDialog();
            // Годы выпуска
            else if (tabControl1.SelectedIndex == 6)
                new AddYear(ref dataGridView7, true).ShowDialog();
            // Распределения
            else if (tabControl1.SelectedIndex == 7)
                new AddRasp(ref dataGridView8, true).ShowDialog();
            // Специальности
            else if (tabControl1.SelectedIndex == 8)
                new AddSpec(ref dataGridView9, true).ShowDialog();
        }


        // Удаление записи из таблицы
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
                return;
            // Выпускники
            if (tabControl1.SelectedIndex == 0)
            {
                DB.DELETE.Student(dataGridView1.SelectedRows[0].Cells[0].Value);
                dataGridView1.Rows.Clear();
                foreach (string[] row in DB.SELECT.Students())
                    dataGridView1.Rows.Add(row);
            }
            // Перераспределения
            if (tabControl1.SelectedIndex == 1)
            {
                DB.DELETE.Rerasp(dataGridView2.SelectedRows[0].Cells[0].Value);
                dataGridView2.Rows.Clear();
                foreach (string[] row in DB.SELECT.Rerasp())
                    dataGridView2.Rows.Add(row);
            }
            // Организации
            if (tabControl1.SelectedIndex == 2)
            {
                DB.DELETE.Org(dataGridView3.SelectedRows[0].Cells[0].Value);
                dataGridView3.Rows.Clear();
                foreach (string[] row in DB.SELECT.Org())
                    dataGridView3.Rows.Add(row);
            }
            // Районы
            if (tabControl1.SelectedIndex == 3)
            {
                DB.DELETE.Dist(dataGridView4.SelectedRows[0].Cells[0].Value);
                dataGridView4.Rows.Clear();
                foreach (string[] row in DB.SELECT.Dist())
                    dataGridView4.Rows.Add(row);
            }
            // Заявки
            if (tabControl1.SelectedIndex == 4)
            {
                DB.DELETE.Zay(dataGridView5.SelectedRows[0].Cells[0].Value);
                dataGridView5.Rows.Clear();
                foreach (string[] row in DB.SELECT.Zay())
                    dataGridView5.Rows.Add(row);
            }
            // Средства обучения
            if (tabControl1.SelectedIndex == 5)
            {
                DB.DELETE.Sred(dataGridView6.SelectedRows[0].Cells[0].Value);
                dataGridView6.Rows.Clear();
                foreach (string[] row in DB.SELECT.Sredstva())
                    dataGridView6.Rows.Add(row);
            }
            // Годы выпуска
            if (tabControl1.SelectedIndex == 6)
            {
                DB.DELETE.Year(dataGridView7.SelectedRows[0].Cells[0].Value);
                dataGridView7.Rows.Clear();
                foreach (string[] row in DB.SELECT.Years())
                    dataGridView7.Rows.Add(row);
            }
            // Распределения
            if (tabControl1.SelectedIndex == 7)
            {
                DB.DELETE.Rasp(dataGridView8.SelectedRows[0].Cells[0].Value);
                dataGridView8.Rows.Clear();
                foreach (string[] row in DB.SELECT.Rasp())
                    dataGridView8.Rows.Add(row);
            }
            // Специальности
            if (tabControl1.SelectedIndex == 8)
            {
                DB.DELETE.Spec(dataGridView9.SelectedRows[0].Cells[0].Value);
                dataGridView9.Rows.Clear();
                foreach (string[] row in DB.SELECT.Speciality())
                    dataGridView9.Rows.Add(row);
            }
            MessageBox.Show("Запись удалена", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Открытие окна добавления выпускника
        private void button1_Click(object sender, EventArgs e) => new AddStudent(ref dataGridView1, false).ShowDialog();


        // Открытие окна добавления района
        private void button2_Click(object sender, EventArgs e) => new AddDist(ref dataGridView4, false).ShowDialog();


        // Открытие окна добавления специальности
        private void button3_Click(object sender, EventArgs e) => new AddSpec(ref dataGridView9, false).ShowDialog();


        // Открытие окна добавления года выпуска
        private void button4_Click(object sender, EventArgs e) => new AddYear(ref dataGridView7, false).ShowDialog();


        // Открытие окна добавления средства обучения
        private void button5_Click(object sender, EventArgs e) => new AddSred(ref dataGridView6, false).ShowDialog();


        // Открытие окна добавления организации
        private void button6_Click(object sender, EventArgs e) => new AddOrg(ref dataGridView3, false).ShowDialog();


        // Открытие окна добавления заявки
        private void button7_Click(object sender, EventArgs e) => new AddZay(ref dataGridView5, false).ShowDialog();


        // Открытие окна добавления распределения
        private void button8_Click(object sender, EventArgs e) => new AddRasp(ref dataGridView8, false).ShowDialog();


        // Открытие окна добавления перераспределения
        private void button9_Click(object sender, EventArgs e) => new AddRerasp(ref dataGridView2, false).ShowDialog();
    }
}
