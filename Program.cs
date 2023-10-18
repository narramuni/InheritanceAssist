using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceAssist
{
    public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        static void runApp()
        {

             


            SubjectTeacher English = new SubjectTeacher();
            English.name = "Praveen";


            SubjectTeacher Maths = new SubjectTeacher();
            Maths.name = "Kumar";


            SubjectTeacher EnglishTeacher = new SubjectTeacher();
            EnglishTeacher.name = "Praveen";

            Console.WriteLine("English Teacher Name: " + EnglishTeacher.name);

            EnglishTeacher.address = "54/5";

            Console.WriteLine("English Teacher Address: " + EnglishTeacher.address);

            EnglishTeacher.dateOfJoining = Convert.ToDateTime("2002-02-2 6:12:26");
            Console.WriteLine("English Teacher Date of Joining: " + EnglishTeacher.dateOfJoining);
            

            EnglishTeacher.refTeacher = English;
            Console.WriteLine("English Teacher's Subject: " + EnglishTeacher.refTeacher.name);

            SubjectTeacher MathsTeacher = new SubjectTeacher();
            MathsTeacher.name = "Kumar";
            Console.WriteLine("Maths Teacher Name: " + MathsTeacher.name);
            MathsTeacher.address = "16/5/52";

            Console.WriteLine("Maths Teacher Address: " + MathsTeacher.address);
            MathsTeacher.dateOfJoining = Convert.ToDateTime("2022-6-2 6:16:52");
            Console.WriteLine("Maths Teacher Date of Joining: " + MathsTeacher.dateOfJoining);


            MathsTeacher.refTeacher = Maths;
            Console.WriteLine("Maths Teacher's Subject: " + MathsTeacher.refTeacher.name);


            CClass class2 = new CClass();
            class2.name = "kiran";


            ClassTeacher teacherOf2 = new ClassTeacher();

            teacherOf2.name = "class2";
            Console.WriteLine("Class 2 Name: " + "Ashok");

            teacherOf2.address = "class2";
            Console.WriteLine("Class 2 address " + "6/6/2");




            teacherOf2.dateOfJoining = Convert.ToDateTime("2016-10-20 00:00:00");
           
           


             Console.WriteLine("Class 2 Teacher Date of Joining: " + "2021-2-16 6:12:26");




            teacherOf2.refTeacher = class2;
            Console.WriteLine("Class 2 Teacher Address: " + "Arithmatic");





            class2.refTeacher = teacherOf2;


            Console.ReadLine();




        }
    }
}
