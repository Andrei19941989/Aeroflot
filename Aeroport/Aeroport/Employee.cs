using System;
using System.Collections.Generic;

namespace Aeroport
{
    public class Employee//класс сотрудника
    {
        private string name { get; set; }
        private string Surname { get; set; }
        private int age;
        private string Sex { get; set; }
        private string Сitizenship { get; set; }

        public Employee(string Name, string Surname, int age, string Sex, string Сitizenship)
        {
            this.name = Name;
            this.Surname = Surname;
            Age = age;
            this.Sex = Sex;
            this.Сitizenship = Сitizenship;


        }



        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 18 || value > 65)
                {
                    throw new ArgumentException("The age must be between 18 and 65");
                }

                age = value;
            }
        }
        
        
        public override string ToString()
        {
            string k = name + " " + Surname + " " + age + " " + Sex + " " + Сitizenship;
            return k;
        }

      
    }
}