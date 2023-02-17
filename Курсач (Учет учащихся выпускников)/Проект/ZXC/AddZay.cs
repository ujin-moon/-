using System;
using System.Collections;
using System.Windows.Forms;

namespace ZXC
{
    public partial class AddZay : Form
    {
        private DataGridView Grid;
        private bool edit_mode;
        private object zay_id;

        public AddZay(ref DataGridView grid, bool edit_mode)
        {
            InitializeComponent();
            this.Grid = grid;
            this.edit_mode = edit_mode;

            ArrayList arr = new ArrayList();
            foreach (string[] item in DB.SELECT.Org())
                arr.Add(new { ID = item[0], Name = item[1] });
            comboBox1.DataSource = arr;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
            ArrayList arr2 = new ArrayList();
            foreach (string[] item in DB.SELECT.Speciality())
                arr2.Add(new { ID = item[0], Name = item[1] });
            comboBox2.DataSource = arr2;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "ID";
            ArrayList arr3 = new ArrayList();
            foreach (string[] item in DB.SELECT.Students())
                arr3.Add(new { ID = item[0], Name = item[1] + ' ' + item[2] + ' ' + item[3] });
            comboBox3.DataSource = arr3;
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "ID";

            if (edit_mode)
            {
                this.Text = "Редактирование записи о заявке";
                button1.Text = "Применить";
                textBox1.Text = Grid.SelectedRows[0].Cells[6].Value.ToString();
                comboBox3.SelectedValue = Grid.SelectedRows[0].Cells[9].Value;
                comboBox2.SelectedValue = Grid.SelectedRows[0].Cells[1].Value;
                comboBox1.SelectedValue = Grid.SelectedRows[0].Cells[1].Value;
                numericUpDown1.Value = Convert.ToInt32(Grid.SelectedRows[0].Cells[5].Value);
                zay_id = Grid.SelectedRows[0].Cells[0].Value;
                numericUpDown2.Value = Convert.ToInt32(Grid.SelectedRows[0].Cells[8].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 2)
            {
                MessageBox.Show("Название должности должно быть не меньше 2 символов", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            if (edit_mode)
            {
                DB.UPDATE.Zay(zay_id, comboBox1.SelectedValue, comboBox2.SelectedValue, (int)numericUpDown1.Value, textBox1.Text, dateTimePicker1.Value, (int)numericUpDown2.Value, comboBox3.SelectedValue);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Zay())
                    Grid.Rows.Add(row);
                this.Close();
            }
            else
            {
                DB.INSERT.Zay(comboBox1.SelectedValue, comboBox2.SelectedValue, (int)numericUpDown1.Value, textBox1.Text, dateTimePicker1.Value, (int)numericUpDown2.Value, comboBox3.SelectedValue);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Zay())
                    Grid.Rows.Add(row);
                this.Close();
            }
        }
    }
}
