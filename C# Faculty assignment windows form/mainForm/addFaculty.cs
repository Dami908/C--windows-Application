using FacultyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainForm
{
    public partial class addFaculty : Form
    {
        Faculty fac;
        public addFaculty()
        {
            InitializeComponent();
           

        }
        public addFaculty(Faculty faculty) : this()
        {
            this.fac = faculty;
            _txtFacultyName.Text = this.fac.Name;
            _txtFacId.Text = this.fac.EmpID.ToString();
            _txtPhn.Text = this.fac.TelephonNumber.ToString();
            _txtStreetbox.Text = this.fac.Address1.Street;
            _txtCity.Text = this.fac.Address1.City;
            _txtProvince.Text = this.fac.Address1.Province;
        }


        private void _onClickAddNewFaculty(object sender, EventArgs e)
        {
                fac.Name = _txtFacultyName.Text;
                fac.EmpID = uint.Parse(_txtFacId.Text);
                fac.TelephonNumber = ulong.Parse(_txtPhn.Text);
                fac.Address1.Street = _txtStreetbox.Text;
                fac.Address1.City =_txtCity.Text;
                fac.Address1.Province = _txtProvince.Text;

                DialogResult = DialogResult.OK;
                Close();
            foreach (TextBox tb in this.Controls.OfType<TextBox>().ToArray())
            {
                tb.Clear();
            }


        }
    }
}
