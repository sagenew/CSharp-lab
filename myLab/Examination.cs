using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLab
{
    class Examination : IMarkName, IComparable
    {
        private int semester;
        public int Semester
        {
            get => semester;
            set => semester = value;
        }

        private string subject;
        public string Subject
        {
            get => subject;
            set => subject = value;
        }

        private string examiner;
        public string Examiner
        {
            get => examiner;
            set => examiner = value;
        }

        private int grade;
        public int Grade
        {
            get => grade;
            set => grade = value;
        }

        private string type;
        public string Type
        {
            get => type;
            set => type = value;
        }

        private DateTime date;
        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        public Examination()
        {
            Semester = Grade = 0;
            Subject = Examiner = Type = "Undefined";
            Date = new DateTime();
        }

        public Examination(int semester, string subject, string examiner, int grade, string type, DateTime date)
        {
            Semester = semester;
            Subject = subject;
            Examiner = examiner;
            Grade = grade;
            Type = type;
            Date = date;
        }

        public string NationalScaleName()
        {
            if (this.grade >= 0 && this.grade < 60) return "Незадовiльно";
            if (this.grade >= 60 && this.grade < 65) return "Достатньо";
            if (this.grade >= 65 && this.grade < 75) return "Задовiльно";
            if (this.grade >= 75 && this.grade < 85) return "Добре";
            if (this.grade >= 85 && this.grade < 95) return "Дуже добре";
            if (this.grade >= 95 && this.grade <= 100) return "Вiдмiнно";
            return "Некоректно вказана оцiнка";
        }

        public string EctsScaleName()
        {
            if (this.grade >= 0 && this.grade < 60) return "F";
            if (this.grade >= 60 && this.grade < 65) return "E";
            if (this.grade >= 65 && this.grade < 75) return "D";
            if (this.grade >= 75 && this.grade < 85) return "C";
            if (this.grade >= 85 && this.grade < 95) return "B";
            if (this.grade >= 95 && this.grade <= 100) return "A";
            return "Некоректно вказана оцiнка";
        }

        public override string ToString() => Semester + ", " + Subject + ", " + Examiner + ", " + Grade + ", " + NationalScaleName() + ", " + EctsScaleName();

        public int CompareTo(object exam)
        {
            return this.semester.CompareTo(((Examination)exam).semester);
        }

    }
}
