using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace CS3321_Project
{
    public class Course
    {
<<<<<<< HEAD
        private string _courseName;
        Dictionary<string, Assignment> _dictAssignment = new Dictionary<string, Assignment>();
=======
        [JsonProperty("courses")]
        public Dictionary<string, CourseInfo> allCourses { get; set; }
>>>>>>> pr/5

        public CourseInfo getInfoOfACourse(string course_id)
        {
<<<<<<< HEAD
            this._courseName = courseName;
        }

        public string GetCourseName()
        {
            return this._courseName;
        }

        public void AddAssignment(Assignment assign)
        {
            _dictAssignment.Add(assign.GetName(), assign);
        }

        public bool UpdateGrade(String name, double grade)
        {
            if (_dictAssignment.ContainsKey(name))
            {
                _dictAssignment[name].SetGrade(grade);
                return true;
            }
            return false;
        }

        public Dictionary<string, Assignment> GetAllAssignment()
        {
            Dictionary<string, Assignment> returnDict = new Dictionary<string, Assignment>();
            foreach (string name in _dictAssignment.Keys)
            {
                returnDict.Add(name, _dictAssignment[name]);
            }

            return returnDict;
        }

        public ArrayList GetAllAssignmentsAsAList()
        {
            ArrayList returnArray = new ArrayList();
            foreach (Assignment item in _dictAssignment.Values)
            {
                returnArray.Add(item);
            }
            return returnArray;
=======
            return allCourses[course_id];
>>>>>>> pr/5
        }

        public void updateACourse(string course_ID, string student_ID, ArrayList assignmentIDList)
        {
            enrolledStudentInfo enroll = new enrolledStudentInfo(student_ID, assignmentIDList);
            allCourses[course_ID].allEnrolledStudent.Add(student_ID, enroll);
        }
    }

<<<<<<< HEAD
        public Assignment GetOneAssignment(string name)
        {
            if (_dictAssignment.ContainsKey(name))
            {
                return _dictAssignment[name];
            }
            return null;
        }
=======
    public class CourseInfo
    {
        [JsonProperty("course_id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("professor")]
        public string professor { get; set; }
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("students")]
        public Dictionary<string, enrolledStudentInfo> allEnrolledStudent { get; set; }
    }
>>>>>>> pr/5

    public class enrolledStudentInfo
    {
        [JsonProperty("studentID")]
        public string id { get; set; }
        [JsonProperty("AssignmentID")]
        public ArrayList assignmentIDList { get; set; }

        public enrolledStudentInfo(string student_id, ArrayList assignmentIDList)
        {
            this.id = student_id;
            this.assignmentIDList = assignmentIDList;
        }
    }
}
