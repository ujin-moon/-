using System;
using System.Collections;
using System.Windows.Forms;


namespace ZXC
{
    public partial class AddRerasp : Form
    {
        private DataGridView Grid;
        private bool edit_mode;
        private object id;


        // Конструктор
        public AddRerasp(ref DataGridView grid, bool edit_mode)
        {
            InitializeComponent();
            this.Grid = grid;
            this.edit_mode = edit_mode;
            ArrayList studs = new ArrayList();
            foreach (string[] item in DB.SELECT.Students())
                studs.Add(new { ID = item[0], Name = item[1] + " " + item[2] + " " + item[3] });
            comboBox1.DataSource = studs;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            ArrayList orgs = new ArrayList();
            foreach (string[] item in DB.SELECT.Org())
                orgs.Add(new { ID = item[0], Name = item[1] });
            comboBox2.DataSource = orgs;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "ID";

            if (edit_mode)
            {
                this.Text = "Редактирование информации о перераспределении";
                button1.Text = "Применить";
                id = Grid.SelectedRows[0].Cells[0].Value;
                comboBox1.SelectedValue = Grid.SelectedRows[0].Cells[1].Value;
                comboBox2.SelectedValue = Grid.SelectedRows[0].Cells[3].Value;
                dateTimePicker1.Value = Convert.ToDateTime(Grid.SelectedRows[0].Cells[5].Value);
                textBox1.Text = Grid.SelectedRows[0].Cells[6].Value.ToString();
                textBox2.Text = Grid.SelectedRows[0].Cells[7].Value.ToString();
            }
        }


        // Закрытие окна
        private void button2_Click(object sender, EventArgs e) => this.Close();


        // Добавление / применение изменений
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 2)
            {
                MessageBox.Show("Название должности должно быть не короче 2 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text.Length < 2)
            {
                MessageBox.Show("Номер подтверждения должен быть не короче 2 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (edit_mode)
            {
                DB.UPDATE.Rerasp(id, comboBox1.SelectedValue, comboBox2.SelectedValue, dateTimePicker1.Value, textBox1.Text, textBox2.Text);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Rerasp())
                    Grid.Rows.Add(row);
                this.Close();
            }
            else
            {
                DB.INSERT.Rerasp(comboBox1.SelectedValue, comboBox2.SelectedValue, dateTimePicker1.Value, textBox1.Text, textBox2.Text);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Rerasp())
                    Grid.Rows.Add(row);
                this.Close();
            }
        }
    }
}
