using System;

namespace ConsoleApp1
{
    public struct Student
    {
        public Student(string name, string surname, int num, bool gender)
        {
            Name = name;
            Surname = surname;
            Num = num;
            Gender = gender;
        }

        public int Num { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }

        public override string ToString()
        {
            return $"{Num} " +
                $"{Name} " +
                $"{Surname} " +
                string.Format(Gender == true ? "Woman" : "Man");
        }

    }
}
