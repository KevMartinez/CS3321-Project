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
<<<<<<< HEAD
        public Database Data;
        public string UserId;
        private User _user;
        private ArrayList _allCourses, _allAssignments;
=======
        private User allUsers;
        private Course allCourses;
        private Assignment allAssignments;
        private string username;
        private List<CourseInfo> allCourseInfo = new List<CourseInfo>();
        private UserInfo thisUserInfo;
>>>>>>> pr/5

        public FrmUserDetail()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
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
=======
        public frm_UserDetail(string username, User allusers, Course allCourse, Assignment allAssignments)
        {
            InitializeComponent();
            this.Width = 279;
            this.username = username;
            this.allUsers = allusers;
            this.allCourses = allCourse;
            this.allAssignments = allAssignments;
        }

        private void frm_UserDetail_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            loadUserInfo();
        }

        private void loadUserInfo()
        {
            UserInfo user = allUsers.getInfoOfAUser(username, false);
            thisUserInfo = user;
            lblName.Text = user.name;
            lblStudentID.Text = "ID: " + user.id;
            lblTotalCourses.Text = user.allEnrolledCourses.Count.ToString() + " courses";
            lblMajor.Text = user.major;
            //get all enrolled courses
            loadEnrolledCourses(user);
        }
>>>>>>> pr/5

        private void loadEnrolledCourses(UserInfo user)
        {
            foreach (var pair in user.allEnrolledCourses)
            {
                var courseID = pair.Key;
                CourseInfo course = allCourses.getInfoOfACourse(courseID);
                allCourseInfo.Add(course);
                var courseName = course.name;
                lstCoursesList.Items.Add(courseName);
            }
        }

        private void LstCoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
=======
            //clear everything
            lstAssignmentList.Items.Clear();
            lstGrade.Items.Clear();
            this.Width = 557;
            lblCourseName.Text = allCourseInfo[lstCoursesList.SelectedIndex].name;
            lblCourseID.Text = allCourseInfo[lstCoursesList.SelectedIndex].id;
            lblProfessor.Text = allCourseInfo[lstCoursesList.SelectedIndex].professor;
            lblCourseType.Text = allCourseInfo[lstCoursesList.SelectedIndex].type;

            loadAssignments();
        }

        private void loadAssignments()
        {
            enrolledCourseInfo enrolled = thisUserInfo.allEnrolledCourses[allCourseInfo[lstCoursesList.SelectedIndex].id];              

            foreach (string id in enrolled.assignmentIDList)
            {
                AssignmentInfo assignment = allAssignments.getInfoOfAAssignment(allCourseInfo[lstCoursesList.SelectedIndex].id).aStudentInfo[thisUserInfo.id].allAssignmentsOfAStudent[id];
                lstAssignmentList.Items.Add(assignment.name);
                lstGrade.Items.Add(assignment.grade);
>>>>>>> pr/5
            }
        }

        private void lstAssignmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstGrade.SelectedIndex = lstAssignmentList.SelectedIndex;
        }

        private void lstGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAssignmentList.SelectedIndex = lstGrade.SelectedIndex;
        }
    }
}
