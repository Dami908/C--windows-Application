using FacultyLib;
using FacultyLib301050676.CourseList;
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
    
    public partial class addAssign : Form
    {
        Course course;
        public addAssign()
        {
            InitializeComponent();
        }
        public addAssign(Faculty faculty1, Course course) : this()
        {
            this.course = course;
            this.course.Faculty = faculty1;
        }

        private void _onClickAddCourse(object sender, EventArgs e)
        {
            if (_checkListBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please, select a course to add to the Faculty.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                switch (_checkListBox.SelectedItem.ToString())
                {
                    case "BSAF100------Introduction to business":
                        _listbox.Items.Add(course.AddCourseItem(new BSAF100()));
                       // _checkListBox.Items.Remove(course.AddCourseItem(new BSAF100()));
                        // _listbox.Items.Remove(_listbox.Items[_checkListBox.SelectedIndex]);
                        //if (_listbox.S> 1)
                        //{
                        //    _listbox.BackColor = Color.Red;
                        //}
                        break;
                    case "BSAF320------Project Management":
                        _listbox.Items.Add(course.AddCourseItem(new BSAF320()));
                        break;
                    case "CECP101------PC Hardware":
                        _listbox.Items.Add(course.AddCourseItem(new CECP100()));
                        break;
                    case "CECP257------The physical Layer":
                        _listbox.Items.Add(course.AddCourseItem(new CECP257()));
                        break;
                    case "COMP120-----Programming1":
                        _listbox.Items.Add(course.AddCourseItem(new COMP120()));
                        break;
                    case "COMP228-----Introduction to java":
                        _listbox.Items.Add(course.AddCourseItem(new COMP228()));
                        break;
                    default:
                        break;


                }
                //_listbox.Text = course.Cost.ToString("C");
                


            }
        }

        private void _onClickOkay(object sender, EventArgs e)
        {
            if (_listbox.Items.Count > 0)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("The Course has no items.", "Attention - Course cancelled Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.Cancel;
            }
            Close();
        }

        private void _onClickCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
