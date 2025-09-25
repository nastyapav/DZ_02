using DZ02.Enums;
using System;
namespace DZ02.Structs
{
    public struct Student
    {
        public string Name;
        public ВУЗ University;
        public Student(string name, ВУЗ university)
        {
            Name = name;
            University = university;
        }
      
            
        
    }
}
