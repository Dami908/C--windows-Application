using FacultyLib;
using FacultyLib301050676;
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
    public partial class _mainForm : Form
    {
        FacultyRepository Saved = new FacultyRepository();
        
        private addAssign _addAssignment;
        private addFaculty _assignFalculty;
        internal List<Faculty> _faculty;

        public _mainForm()
        {
            InitializeComponent();

            _faculty = new List<Faculty>();
            _addAssignment = new addAssign();
            _assignFalculty = new addFaculty();
        }

        private void _onClickAddFaculty(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty();
            addFaculty frmcustomer = new addFaculty(faculty);
            DialogResult dr = frmcustomer.ShowDialog();

            if (dr == DialogResult.OK)
            {
                _lstFaculty.Items.Add(faculty);
                 Saved.Add(faculty);
            }
            if (dr == DialogResult.Cancel)
            {
                Faculty.IdCount--;
            }
        }

        private void _onClickAddAssignment(object sender, EventArgs e)
        {
            if (_lstFaculty.SelectedIndex >= 0)
            {
                Faculty faculty = new Faculty();
                Course course = new Course();
                faculty = _lstFaculty.SelectedItem as Faculty;
                addAssign courseAssign = new addAssign(faculty, course);
                DialogResult dr = courseAssign.ShowDialog();
                if (dr == DialogResult.OK)
                {
                   
                    faculty.AddCourse(course);
                    refreshCourses();
                    MessageBox.Show("Course for " + faculty.Name + " successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (dr == DialogResult.Cancel)
                {
                    Course.IdCount--;
                }

            }
            
            else
            {
                MessageBox.Show("Please, select/Input a Faculty to assign a course to.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void saveRepository()
        {
            Saved.Save("Customers.json");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveRepository();
            MessageBox.Show("Faculties with their courses are successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _onActivateForm(object sender, EventArgs e)
        {

            //this._lstFaculty.Items.AddRange(this._faculty.ToArray());
           // this._faculty.Clear();
        }

        private void _mainForm_Load(object sender, EventArgs e)
        {
            _lstFaculty.DisplayMember = "Faculty.Name";
            _lstAssignment.DisplayMember = "Course.CourseCode"; 
            
        }

        private void _lstFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshCourses();
        }

        private void refreshCourses()
        {
            _lstAssignment.DataSource = null;
            _lstAssignment.DataSource = (_lstFaculty.SelectedItem as Faculty).Course1;
        }
        //Action that takes plave when the course assignment button is selected
        private void _btnCourseAssignment_click(object sender, EventArgs e)
        {
            List<Faculty> faculties = new List<Faculty>();
            for (int i = 0; i < Saved.Faculty.Count; i++)
            {
                faculties.Add(Saved.Faculty[i]);
            }
            string title = "Please select a faculty to check if a course was assigned if empty no course was assigned";
            _frmFacultyCourse frmCustomersAndCourse = new _frmFacultyCourse(faculties, title);
            frmCustomersAndCourse.ShowDialog();

        }

        private void _btnCheckCourse_click(object sender, EventArgs e)
        {
            bool courseMatch = false;
            List<Faculty> matchedfaculties = new List<Faculty>();
            matchedfaculties.Clear();
            string testcoursecode = button1.Text;
            foreach(Faculty fac in matchedfaculties   )
            {
                foreach(Course item in fac.Course1)
                {
                    if (item.CourseCode == testcoursecode)
                    {
                        courseMatch = true;
                        break;
                    }
                    else
                    {
                        courseMatch = false;
                    }
                }
                if (courseMatch == true)
                {
                    matchedfaculties.Add(fac);
                }

            }
            _lstAssignment.Items.AddRange(matchedfaculties.ToArray());

        }

        private void _checkCourse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
