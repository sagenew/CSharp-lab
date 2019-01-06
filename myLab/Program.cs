using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLab
{
    class Program
    {
        //Arthur Humenchuk, IP-71, Variant 9
        static void Main(string[] args)
        {
            Student student = new Student(
                "Ivan",
                "Ivanov",
                new DateTime(2000, 1, 1),
                Education.Bachelor,
                "IP-71",
                new Examination[]
                {
                    new Examination(2, "Ukrainian language", "Zhyk K.M.", 70, "credit", new DateTime(2018, 6, 5))
                });
            Console.WriteLine(student.ToString());

            Examination[] newExams =
            {
                new Examination(1, "Matan", "Orlovski Y.O.", 66, "exam", new DateTime(2018,10,3)),
                new Examination(2, "Physics", "Linchevski S.D.", 89, "credit", new DateTime(2018, 12, 10)),
                new Examination(1, "LinAl", "Prohorenko L.M.", 79, "credit", new DateTime(2017, 12, 12)),
                new Examination(3, "Psychology", "Kononets M.O.", 95, "credit", new DateTime(2018, 12, 15)),
                new Examination(3, "OOP", "Mukha I.P.", 60, "exam", new DateTime(2018, 12, 10)),
                new Examination(3, "OCD", "Kovtunets O.V.", 100, "credit", new DateTime(2018, 12, 18)),
            };
            student.AddExams(newExams);
            Console.WriteLine(student.ToString());
            student.PrintFullInfo();
            
            Console.WriteLine("\nTask #2:");
            Person person1 = new Person("Ivan", "Ivanov", new DateTime(2000, 1, 1));
            Person person2 = new Person("Ivan", "Ivanov", new DateTime(2000, 1, 1));
            Person person3 = new Person("Eugene", "Sagenew", new DateTime(2000, 7, 27));
            person1.PrintFullInfo();
            person2.PrintFullInfo();
            person3.PrintFullInfo();
            Console.WriteLine(person1 == person2); 
            Console.WriteLine(person1 != person3); 

            Console.WriteLine("\nTask #5:");
            Console.WriteLine("Printing exams with grades higher than 85:");
            foreach (Examination i in student.GetExamsMore(85)) Console.WriteLine(i);

            Console.WriteLine("\nTask #10:");
            Console.WriteLine("Printing exams sorted by semester:");
            Examination[] examsSorted = student.GetArrayOfExams();
            foreach (Examination i in examsSorted) Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
