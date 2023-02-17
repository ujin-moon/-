using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZXC
{
    public partial class AddSred : Form
    {
        private DataGridView Grid;
        private bool edit_mode;
        private object sred_id;


        public AddSred(ref DataGridView grid, bool edit_mode)
        {
            InitializeComponent();
            this.Grid = grid;
            this.edit_mode = edit_mode;

            if (edit_mode)
            {
                this.Text = "Редактирование записи чредства обучения";
                this.button1.Text = "Применить";
                this.sred_id = Grid.SelectedRows[0].Cells[0].Value;
                this.textBox1.Text = Grid.SelectedRows[0].Cells[1].Value.ToString();
            }

            this.ActiveControl = textBox1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 2)
            {
                MessageBox.Show("Название средства обучения не может быть короче 2 символов", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }
            if (edit_mode)
            {
                DB.UPDATE.Sred(sred_id, textBox1.Text);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Sredstva())
                    Grid.Rows.Add(row);
                this.Close();
            }
            else
            {
                DB.INSERT.Sred(textBox1.Text);
                Grid.Rows.Clear();
                foreach (string[] row in DB.SELECT.Sredstva())
                    Grid.Rows.Add(row);
                this.Close();
            }
        }
    }
}
