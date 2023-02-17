using System;
using System.Collections;
using System.Windows.Forms;

namespace ZXC
{
    public partial class AddOrg : Form
    {
        private DataGridView Grid;
        private bool edit_mode;
        private object org_id;


        public AddOrg(ref DataGridView grid, bool edit_mode)
        {
            InitializeComponent();
            this.Grid = grid;
            this.edit_mode = edit_mode;
            ArrayList arr = new ArrayList();
            foreach (string[] item in DB.SELECT.Dist())
                arr.Add(new { ID = item[0], Name = item[1] });
            comboBox1.DataSource = arr;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";

            if (edit_mode)
            {
                this.Text = "Редактирование записи об организации";
                button1.Text = "Применить";
                textBox1.Text = Grid.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = Grid.SelectedRows[0].Cells[4].Value.ToString();
                textBox3.Text = Grid.SelectedRows[0].Cells[5].Value.ToString();
                comboBox1.SelectedValue = Grid.SelectedRows[0].Cells[2].Value;
                org_id = Grid.SelectedRows[0].Cells[0].Value.ToString();
            }

            this.ActiveControl = textBox1;
        }


        private void button2_Click(object sender, EventArgs e) => this.Close();


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 2)
            {
                MessageBox.Show("Наименование организации должно быть длиной не менее 2 символов", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text.Length < 2)
            {
                MessageBox.Show("Наименование населённого пункта должно быть длиной не менее 2 символов", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            if (textBox3.Text.Length < 2)
            {
                MessageBox.Show("Адрес должен быть длиной не менее 2 символов", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            if (edit_mode)
            {
                DB.UPDATE.Org(org_id, textBox1.Text, comboBox1.SelectedValue, textBox2.Text, textBox3.Text);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Org())
                    Grid.Rows.Add(row);
                this.Close();
            }
            else
            {
                DB.INSERT.Org(textBox1.Text, comboBox1.SelectedValue, textBox2.Text, textBox3.Text);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Org())
                    Grid.Rows.Add(row);
                this.Close();
            }
        }
    }
}
