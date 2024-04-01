using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SMNK_Lab_13_OOP
{
    public partial class fPeople : Form
    {
        public People ThePeople;
        public fPeople(People t)
        {
            ThePeople = t;
            InitializeComponent();
        }


        private void fPerson_Load(object sender, EventArgs e)
        {
            tbname.Text = ThePeople.Name;
            tbsurname.Text = ThePeople.Surname;
            tbnationality.Text = ThePeople.Nationality;
            tbsex.Text = ThePeople.Sex;
            tbyearofbirth.Text = ThePeople.YearOfBirth.ToString("0");
            cBprava.Checked = ThePeople.Prava;
            chBpassport.Checked = ThePeople.Zakordonnyi;
        }

        private void chBpassport_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ThePeople.Name = tbname.Text.Trim();
            ThePeople.Surname = tbsurname.Text.Trim();
            ThePeople.Nationality = tbnationality.Text.Trim();
            ThePeople.Sex = tbsex.Text.Trim();
            ThePeople.YearOfBirth = int.Parse(tbyearofbirth.Text.Trim());
            ThePeople.Prava = cBprava.Checked;
            ThePeople.Zakordonnyi = chBpassport.Checked;

            DialogResult = DialogResult.OK;
        }

        private void cBprava_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
