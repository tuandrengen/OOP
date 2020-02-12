using System;
using System.Collections.Generic;
using System.Text;
//IO namespace
using System.IO;

namespace Object_Oriented_Programming
{
    class DataStorage
    {
        // Save a 'school' object to a file
        public static void Store(School school)
        {
            FileStream stream = new FileStream(
                school.schoolName + ".dat", FileMode.Create);

            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(school.schoolName);
            writer.WriteLine(school.schoolStudents + "student(s)");
            writer.WriteLine(school.schoolProfessors + "professor(s)");

            writer.Close();

        }
    }
}
