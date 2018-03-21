using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CS3321_Project
{
    class Course
    {
        private string _courseName;
        Dictionary<string, Assignment> _dictAssignment = new Dictionary<string, Assignment>();

        public Course(string courseName)
        {
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
        }

        public Assignment GetOneAssignment(string name)
        {
            if (_dictAssignment.ContainsKey(name))
            {
                return _dictAssignment[name];
            }
            return null;
        }

    }
}
