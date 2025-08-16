using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Teacher
    {
        public int Num { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }

        //Default ctor
       public Teacher()
        {

        }

        public Teacher(int num, string name, string surname, bool gender)
        {
            Num = num;
            Name = name;
            Surname = surname;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{Num} {Name} {Surname} " +
                string.Format(Gender == true ? "Woman" : "Man");
        }
    }
}
