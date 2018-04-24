using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3321_Project
{
    {

        private string _assignmentName;
        private double _assignmentGrade;

        public Assignment(string name)
        {
            this.SetAssignment(name, -1);
        }

        public Assignment (string name, double grade)
        {
            this.SetAssignment(name, grade);
        }

        public void SetAssignment(string name, double grade)
        {
            this._assignmentName = name;
            this._assignmentGrade = grade;
        }

        public string GetName()
        {
            return this._assignmentName;
        }

        public double GetGrade()
        {
            return this._assignmentGrade;
        }

        public void SetGrade(double grade)
        {
            this._assignmentGrade = grade;
        }

        public override string ToString()
        {
            return "Assignment: " + GetName() + " - Grade: " + GetGrade();
        }
    }

    
}
