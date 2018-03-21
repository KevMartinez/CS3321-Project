using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3321_Project
{
    class StudentCourse : Course
    {
        private string _professorName;

        public StudentCourse(string courseName, string professor) : base(courseName)
        {
            this._professorName = professor;
        }

        public string GetProfessorName()
        {
            return this._professorName;
        }
    }
}
