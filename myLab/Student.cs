using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLab
{
    enum Education
    {
        Master,
        Bachelor,
        SecondEducation,
        PhD
    }
    class Student : Person
    {
        public Student(
            string firstName, 
            string secondName, 
            DateTime birthday, 
            Education qualification, 
            string group, 
            Examination[] passedExams)
        {
            FirstName = firstName;
            SecondName = secondName;
            Birthday = birthday;
            Qualification = qualification;
            Group = group;
            PassedExams = passedExams;

        }

        private Education Qualification;
        private string group;
        public string Group
        {
            get => group;
            set => group = value;
        }

        private Examination[] PassedExams;
        private double AverageRating
        {
            get
            {
                int score = 0;
                foreach (Examination exam in PassedExams)
                {
                    score += exam.Grade;
                }
                return score / PassedExams.Length;
            }
        }
        public void AddExams(Examination[] examList)
        {
            Examination[] newExamList = new Examination[PassedExams.Length + examList.Length];
            PassedExams.CopyTo(newExamList, 0);
            examList.CopyTo(newExamList, PassedExams.Length);
            PassedExams = newExamList;
        }
        public override string ToString() => FirstName + ", " + SecondName + ", " + Group;
        public override void PrintFullInfo()
        {
            Console.WriteLine("First name: " + FirstName);
            Console.WriteLine("Second name: " + SecondName);
            Console.WriteLine("Birthday: " + Birthday.ToShortDateString());
            Console.WriteLine("Qualification: " + Qualification);
            Console.WriteLine("Group: " + Group);
            Console.WriteLine("Average rating: " + AverageRating);
            Console.WriteLine("Passed exams:");
            foreach (Examination exam in PassedExams)
            {
                Console.WriteLine(exam.ToString());
            }
        }

        public IEnumerable<Examination> GetExamsMore(int compareGrade)
        {
            foreach (Examination i in this.PassedExams)
            {
                if (i.Grade > compareGrade) yield return i;
            }
        }

        public Examination[] GetArrayOfExams()
        {
            Examination[] result = this.PassedExams.ToArray();
            Array.Sort(result);
            return result;
        }

    }
}
