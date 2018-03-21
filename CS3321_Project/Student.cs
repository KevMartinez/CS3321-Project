using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3321_Project
{
    class Student : User
    {
        public Student(string userId, string password, string name, string type) : base(userId, password, name, "Student") {}
        private Dictionary<string, StudentCourse> _dictCourses = new Dictionary<string, StudentCourse>();

        public void AddCourse(StudentCourse course)
        {
            _dictCourses.Add(course.GetCourseName(), course);
        }

        public Dictionary<string, StudentCourse> GetAllCourses()
        {
            var returnDict = new Dictionary<string, StudentCourse>();
            foreach (var name in _dictCourses.Keys)
            {
                returnDict.Add(name, _dictCourses[name]);
            }

            return returnDict;
        }

        public StudentCourse GetACourse(string course)
        {
            return _dictCourses.ContainsKey(course) ? _dictCourses[course] : null;
        }

        public override ArrayList GetAllCourseAsAList()
        {
            ArrayList returnArray = new ArrayList();
            foreach (var item in _dictCourses.Values) {
                returnArray.Add(item);
            }
            return returnArray;
        }
    }
}
