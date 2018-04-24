using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3321_Project {
<<<<<<< HEAD
    public class Database {
        private static Dictionary<string, User> _dictAccount = new Dictionary<string, User>();

        public Database()
        {
            LoadDatabase();
        }

        public void LoadDatabase()
        {
            //For English Class, Professor Jason, total Student = 5, total Assignments = 3
            Professor pro1 = new Professor("2111", "999", "Jason", "Statham");
            ProfessorCourse eng = new ProfessorCourse("English");
            ProfessorCourse chem = new ProfessorCourse("Chemistry");
            pro1.AddCourse(eng);
            pro1.AddCourse(chem);

            //Pro2
            Professor pro2 = new Professor("2112", "999", "Henry", "Ford");
            ProfessorCourse math = new ProfessorCourse("Math");
            ProfessorCourse biology = new ProfessorCourse("Biology");
            pro2.AddCourse(biology);
            pro2.AddCourse(math);

            int totalStudent = 5;
            Student[] allStudents = new Student[totalStudent];

            Student s1 = new Student("1111", "999", "Justin", "Bieber");
            Student s2 = new Student("1112", "999", "Charlie", "Puth");
            Student s3 = new Student("1113", "999", "Selena", "Gomez");
            Student s4 = new Student("1114", "999", "Taylor", "Swift");
            Student s5 = new Student("1115", "999", "Bruno", "Mars");

            allStudents[0] = s1;
            allStudents[1] = s2;
            allStudents[2] = s3;
            allStudents[3] = s4;
            allStudents[4] = s5;

            //English Class
            foreach (var t in allStudents)
            {
                pro1.GetACourse(eng.GetCourseName()).AddStudent(t.GetName(), t.GetId());
                t.AddCourse(new StudentCourse("English", "Jason Statham"));
                t.GetACourse("English").AddAssignment(new Assignment("Homework1", 0));
                t.GetACourse("English").AddAssignment(new Assignment("Homework2", 0));
                t.GetACourse("English").AddAssignment(new Assignment("Homework3", 0));
                t.GetACourse("English").AddAssignment(new Assignment("Midterm Review", 0));
                t.GetACourse("English").AddAssignment(new Assignment("Midterm Exam", 0));

                _dictAccount.Add(t.GetId(), t);
            }

            //Chem
            for (var i = 0; i < allStudents.Length - 3; i++)
            {
                pro1.GetACourse(chem.GetCourseName()).AddStudent(allStudents[i].GetName(), allStudents[i].GetId());
                allStudents[i].AddCourse(new StudentCourse("Chemistry", "Jason Statham"));
                allStudents[i].GetACourse("Chemistry").AddAssignment(new Assignment("Lab Practice", 0));
                allStudents[i].GetACourse("Chemistry").AddAssignment(new Assignment("Exam 1", 0));
            }

            pro1.GetACourse(eng.GetCourseName()).AddAssignment(new Assignment("Homework1"));
            pro1.GetACourse(eng.GetCourseName()).AddAssignment(new Assignment("Homework2"));
            pro1.GetACourse(eng.GetCourseName()).AddAssignment(new Assignment("Homework3"));
            pro1.GetACourse(eng.GetCourseName()).AddAssignment(new Assignment("Midterm Review"));
            pro1.GetACourse(eng.GetCourseName()).AddAssignment(new Assignment("Midterm Exam"));

            pro1.GetACourse(chem.GetCourseName()).AddAssignment(new Assignment("Lab Practice"));
            pro1.GetACourse(chem.GetCourseName()).AddAssignment(new Assignment("Exam 1"));

            _dictAccount.Add(pro1.GetId(), pro1);

            //Professor 2
            for (var i = 2; i < allStudents.Length; i++)
            {
                pro2.GetACourse(math.GetCourseName()).AddStudent(allStudents[i].GetName(), allStudents[i].GetId());
                allStudents[i].AddCourse(new StudentCourse("Math", "Henry Ford"));
                allStudents[i].GetACourse("Math").AddAssignment(new Assignment("Presentation", 0));
                allStudents[i].GetACourse("Math").AddAssignment(new Assignment("Take home quiz", 0));
                allStudents[i].GetACourse("Math").AddAssignment(new Assignment("Essay", 0));
            }

            //Biology

            for (var i = 1; i < allStudents.Length - 1; i++)
            {
                pro2.GetACourse(biology.GetCourseName()).AddStudent(allStudents[i].GetName(), allStudents[i].GetId());
                allStudents[i].AddCourse(new StudentCourse("Biology", "Henry Ford"));
                allStudents[i].GetACourse("Biology").AddAssignment(new Assignment("Quiz 1", 0));
                allStudents[i].GetACourse("Biology").AddAssignment(new Assignment("Project", 0));
            }

            pro2.GetACourse(math.GetCourseName()).AddAssignment(new Assignment("Presentation"));
            pro2.GetACourse(math.GetCourseName()).AddAssignment(new Assignment("Take home quiz"));
            pro2.GetACourse(math.GetCourseName()).AddAssignment(new Assignment("Essay"));

            pro2.GetACourse(biology.GetCourseName()).AddAssignment(new Assignment("Quiz 1"));
            pro2.GetACourse(biology.GetCourseName()).AddAssignment(new Assignment("Project"));

            _dictAccount.Add(pro2.GetId(), pro2);

            Console.WriteLine("Database was loaded successfully!");
        }

        public bool CheckUserLogin(string userId, string password)
        {
            if (_dictAccount.ContainsKey(userId))
            {
                return _dictAccount[userId].GetPassword().Equals(password, StringComparison.OrdinalIgnoreCase);
            } else
            {
                return false;
            }
        }

        public User GetUserInformation(string userId)
        {
            return _dictAccount.ContainsKey(userId) ? _dictAccount[userId] : null;
        }
=======
    
>>>>>>> pr/5

    public class Database {
        
    }
}
