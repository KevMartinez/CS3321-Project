using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CS3321_Project
{
    public partial class  FrmUserDetail : Form
    {
        public Database Data;
        public string UserId;
        private User _user;
        private ArrayList _allCourses, _allAssignments;

        public FrmUserDetail()
        {
            InitializeComponent();
        }

        private void Frm_UserDetail_Load(object sender, EventArgs e)
        {
            if (UserId != null)
            {
                _user = Data.GetUserInformation(UserId);
                lblName.Text = _user.GetTypeOfUser() + @": " + _user.GetName();
                lblStudentID.Text = @"ID: " + _user.GetId();
                _allCourses = _user.GetAllCourseAsAList();

                foreach (var t in _allCourses)
                {
                    StudentCourse stu = (StudentCourse)t;
                    lstCoursesList.Items.Add(stu.GetCourseName());
                }

            }

            
        }

        private void LstCoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAssignments.Items.Clear();
            lstGrades.Items.Clear();
            StudentCourse selectedCourse = (StudentCourse)_allCourses[lstCoursesList.SelectedIndex];
            _allAssignments = selectedCourse.GetAllAssignmentsAsAList();
            lblProfessor.Text = @"Professor: " + selectedCourse.GetProfessorName();

            foreach (var t in _allAssignments)
            {
                Assignment assign = (Assignment)t;
                lstAssignments.Items.Add(assign.GetName() + "\t\t");
                lstGrades.Items.Add(assign.GetGrade());
            }

        }
    }
}
