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
    public partial class _frmFacultyCourse : Form
    {
        int requestType;
        public _frmFacultyCourse()
        {
            InitializeComponent();
        }
        public _frmFacultyCourse(List<Faculty> faculties, string title, string groupName = "Course Details", int requestType = 0) : this()
        {
            this.Text = title;
            this.requestType = requestType;
            _grpboxCourse.Text = groupName;// accesses the form  group box 
            //Adds a new faculties object to the list of Faculty
            foreach (Faculty faculty in faculties)
            {
                _lbxFaculty.Items.Add(faculty);
            }

        }

        private void _frmFacultyAndCourse_Load(object sender, EventArgs e)
        {
            _lbxFaculty.DisplayMember = "Faculty.Name";
            //Sorts the faculty list box in alphabetic order 
            _lbxFaculty.Sorted = true;
        }

        private void _bxFaculty_SelectedIndex(object sender, EventArgs e)
        {
         
           
            ShowCourse();
            
        }
        private void ShowCourse()
        {
            _lstboxCourseDetails.Items.Clear();
            for (int i = 0; i < ((_lbxFaculty.SelectedItem as Faculty)).Course1.Count; i++)
            {
                //Adds a new course for very assignment made
                _lstboxCourseDetails.Items.Add("--------- Course ---------");
                foreach (NewCourseList item in (_lbxFaculty.SelectedItem as Faculty).Course1[i].Items)
                {

                    
                    _lstboxCourseDetails.Items.Add(item as NewCourseList);
                   
                }
            }
            
        }

        private void _btnClick_click(object sender, EventArgs e)
        {
            //If  the button is clicked form will close
            Close();
        }
    }
}
