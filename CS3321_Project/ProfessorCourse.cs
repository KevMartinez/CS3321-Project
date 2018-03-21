using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CS3321_Project
{
    class ProfessorCourse : Course
    {
        private Dictionary<string, string> _dictStudent = new Dictionary<string, string>();

        public ProfessorCourse(string courseName) : base(courseName)
        {
        }

        public void AddStudent(string userId, string name)
        {
            _dictStudent.Add(userId, name);
        }

        public Dictionary<string, string> GetAllStudents()
        {
            Dictionary<string, string> returnDict = new Dictionary<string, string>();
            foreach (string userId in _dictStudent.Keys)
            {
                returnDict.Add(userId, _dictStudent[userId]);
            }

            return returnDict;
        }

         
    }
}
