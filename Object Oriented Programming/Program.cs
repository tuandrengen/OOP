using System;

namespace Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //char a = "a"; // chars use apostrophe, not quotations ('a')
            //bool b = 0; // bool is a 'true or false' statement (true/false)
            //int c = 8.0; // double, can not convert to int (8)
            //decimal d = 6.7; // (6.7M)
            //string e = "Have you seen \"Holger\"?"; //Make use of unicode escape character (\") to make the program read the quotation marks
            //char a = 'a';
            //bool b = true;
            //int c = 8;
            //decimal d = 6.7M;
            //string e = "Have you seen \"Holger\"?";

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);

            //calculateDegreeToRadian();
            //calculateRadianToDegree();
            //reverseStars();
            //squareroot();

            //groupsTwo();

            School school1 = new School();
            School school2;
            school2 = new School();

            school1.schoolName = "Aalborg Universitet";
            school1.schoolStudents = 0;
            school1.schoolProfessors = 50;
            populateSchoolWithStudents(school1);

            Console.WriteLine("{0} has {1} student(s) and {2} professor(s).", 
                school1.schoolName, school1.schoolStudents, school1.schoolProfessors);

            Console.Write($"{ school1.GetName() } " + "has {0} student(s) and {1} professor(s).", 
                school1.schoolStudents, school1.schoolProfessors);
        }

        static void populateSchoolWithStudents(School school)
        {
            school.schoolStudents = 520;
        }

        static void stars()
        {
            int resultat;
            while (!int.TryParse(Console.ReadLine(), out resultat)) ;

            for (int i = 0; i < resultat; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void reverseStars()
        {
            int resultat;
            while (!int.TryParse(Console.ReadLine(), out resultat)) ;

            for(int i=resultat; i>0; i--)
            {
                for (int j=0; j<i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void calculateDegreeToRadian()
        {
            double i = degreeToRadian(299);
            Console.WriteLine(i);
        }

        static void calculateRadianToDegree()
        {
            double i = radianToDegree(4);
            Console.WriteLine(i);
        }

        static double radianToDegree(double radian)
        {
            double pi = 3.14;
            return radian * (180 / pi);
        }

        static double degreeToRadian(double degree)
        {
            double pi = 3.14;
            return degree * (pi / 180);
        }

        static void squareroot()
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            var result = Math.Sqrt(number);
            Console.WriteLine("The squareroot of {0} is {1}", number, result);
        }

        static void groups()
        {
            Console.WriteLine("How many members are there in your group?");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            string[] membersArray = new string[10];
            
            for (int i = 1; i<=number; i++)
            {

                Console.Write("Type the name of group member #{0} ", i);
                membersArray[i-1] = Console.ReadLine();

            }

            Console.WriteLine();

            foreach (var i in membersArray) {
                if (i == null)
                {
                    break;
                }
                Console.WriteLine(i);
                
            }
        }

        static void groupsTwo()
        {
            int member = 1;
            string name;
            string[] groupArray = new string[10];
            do
            {
                Console.Write("Type the name of group member #{0}: ", member);
                name = Console.ReadLine();
                groupArray[member - 1] = name;
                member++;
            } while (!(name == string.Empty));

            Console.WriteLine();

            foreach(string i in groupArray)
            {
                if (i == null)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
