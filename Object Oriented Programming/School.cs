using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming
{
    class School
    {
        public string schoolName;
        public int schoolStudents;
        public int schoolProfessors;

        public string GetName()
        {
            return $"{ schoolName }";
        }

        public void SetName(string oldSchoolName, string newSchoolName)
        {
            this.schoolName = newSchoolName;
            Console.WriteLine($"{oldSchoolName} has changed its name to '{ this.GetName()}'");
        }

        public void Save()
        {
            DataStorage.Store(this);
        }
    }
}
