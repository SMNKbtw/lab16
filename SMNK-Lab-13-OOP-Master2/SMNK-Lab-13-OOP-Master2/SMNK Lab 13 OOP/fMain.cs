using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMNK_Lab_13_OOP
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvPeople.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Ім\'я";
            gvPeople.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); 
            column.DataPropertyName = "Surname"; 
            column.Name = "прізвище"; 
            gvPeople.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); 
            column.DataPropertyName = "Sex"; 
            column.Name = "Стать"; 
            gvPeople.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); 
            column.DataPropertyName = "Nationality"; 
            column.Name = "Національність";
            gvPeople.Columns.Add(column);

            column = new DataGridViewTextBoxColumn(); 
            column.DataPropertyName = "YearOfBirth"; 
            column.Name = "Рік народження";
            gvPeople.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Zakordonnyi";
            column.Name = "Закорд. паспорт";
            column.Width = 80;
            gvPeople.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn(); 
            column.DataPropertyName = "Prava"; 
            column.Name = "Вод. права"; column.Width = 80;
            gvPeople.Columns.Add(column);


            bindSrcPeople.Add(new People("Данило", "Семенюк", "Чоловік", "Українець", 2004, true, false));

            EventArgs args = new EventArgs();
            OnResize(args);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            People people = new People();

            fPeople ft = new fPeople(people);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcPeople.Add(people);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            People people = (People)bindSrcPeople.List[bindSrcPeople.Position];

            fPeople ft = new fPeople(people);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcPeople.List[bindSrcPeople.Position] = people;
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
        "Видалення запису", MessageBoxButtons.OKCancel,
        MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcPeople.RemoveCurrent();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
    "Очистити таблицю?\n\nВсі дані будуть втрачені",
    "Очищення даних", MessageBoxButtons.OKCancel,
     MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcPeople.Clear();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
    "Очистити таблицю?\n\nВсі дані будуть втрачені",
    "Очищення даних", MessageBoxButtons.OKCancel,
     MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcPeople.Clear();
            }
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
          MessageBoxButtons.OKCancel,
          MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }

        }
    }
}
