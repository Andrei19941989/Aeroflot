using System;
using System.Collections.Generic;

namespace Aeroport
{
    public class Buyer//описывает класс покупателя
    {
        private string login;
        private string password;
        private string name;
        private string surname;
        private  int age;
        private int coin;

        public Buyer(string login,string password,string name, string surname, int Age, int Coin)
        {
            this.login = login;
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.Age = Age;
            this.Coin = Coin;
        }

        public string Login
        {
            get
            {
                return login;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
        }
        public string  Name
        {
            get
            {
                return name;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
        }


        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 18 || value > 100)
                {
                    throw new Exception("The age must be between 18 and 100");
                }

                age = value;
            }
        }

        public int Coin
        {
            get
            {
                return coin;
            }
            set
            {
                if (value < 0 || value > 10000)
                {
                    throw new Exception("The age must be between 1 and 10000");
                }

               
                coin = value;
            }
        }
        public override string ToString()
        {
            string h = login + " " + password + " " + name + " " + surname + " " + age + " " + coin;
            return h;
        }
        
        
        
    }
}