using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CS3321_Project
{
    class Professor : User
    {
        private Dictionary<string, ProfessorCourse> _dictCourses = new Dictionary<string, ProfessorCourse>();

        public Professor(string userId, string password, string name, string type) : base(userId, password, name, "Professor")
        {
        }

        public void AddCourse(ProfessorCourse course)
        {
            _dictCourses.Add(course.GetCourseName(), course);
        }

        public Dictionary<string, ProfessorCourse> GetAllCourses()
        {
            Dictionary<string, ProfessorCourse> returnDict = new Dictionary<string, ProfessorCourse>();
            foreach (string name in _dictCourses.Keys)
            {
                returnDict.Add(name, _dictCourses[name]);
            }

            return returnDict;
        }

        public ProfessorCourse GetACourse(string course)
        {
            return _dictCourses.ContainsKey(course) ? _dictCourses[course] : null;
        }

        public bool CheckCourseExist(string course)
        {
            return _dictCourses.ContainsKey(course);
        }

        public override ArrayList GetAllCourseAsAList()
        {
            var returnArray = new ArrayList();
            foreach (var item in _dictCourses.Values)
            {
                returnArray.Add(item);
            }
            return returnArray;
        }

        public ArrayList GetAllStudentsOfACourse(string course, string dorName)
        {
            var returnArr = new ArrayList();
            if (dorName.Equals("id", StringComparison.OrdinalIgnoreCase))
            {
                foreach (var userid in _dictCourses[course].GetAllStudents().Keys)
                {
                    returnArr.Add(userid);
                }
                return returnArr;
            } else
            {
                foreach (var name in _dictCourses[course].GetAllStudents().Values)
                {
                    returnArr.Add(name);
                }
                return returnArr;
            }
        }
    }
}
