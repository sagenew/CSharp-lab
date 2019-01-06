using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLab
{
    class Person
    {
        private string firstName;
        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        private string secondName;
        public string SecondName
        {
            get => secondName;
            set => secondName = value;
        }
        private DateTime birthday;
        public DateTime Birthday
        {
            get => birthday;
            set => birthday = value;
        }
        public int BirthdayYear
        {
            get => Birthday.Year;
            set => Birthday = new DateTime(value, Birthday.Month, Birthday.Day);
        }
        public Person()
        {
            FirstName = SecondName = "None";
            Birthday = new DateTime();
        }
        public Person(string firstName, string secondName, DateTime birthday)
        {
            FirstName = firstName;
            SecondName = secondName;
            Birthday = birthday;
        }
        public virtual void PrintFullInfo()
        {
            Console.WriteLine("First name: " + FirstName);
            Console.WriteLine("Second name: " + SecondName);
            Console.WriteLine("Birthday: " + Birthday.ToShortDateString());
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Person comparePerson = (Person)obj;
                return (FirstName == comparePerson.FirstName) &&
                       (FirstName == comparePerson.FirstName) && 
                       System.DateTime.Equals(Birthday, comparePerson.Birthday);
            }
        }

        public override int GetHashCode()
        {
            int result = this.firstName.Length + this.firstName.Length;
            result += this.birthday.ToLongDateString().Length;
            return result;
        }

        public static bool operator ==(Person obj1, Person obj2)
        {
            if (obj1.Equals(obj2)) return true;
            return false;
        }

        public static bool operator !=(Person obj1, Person obj2)
        {
            if (obj1.Equals(obj2)) return false;
            return true;
        }
    }
}
