using System;
namespace Aeroport
{
    public class Prod:Admin
    {
        private  string bank;
        private string password;
        public Prod(string Phone, string Seria, string Number,string Bank,string Password) : base(Phone, Seria, Number)
        {
            this.Bank = Bank;
            this.Password = Password;
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length <=5) throw new Exception("bad password");
                password = value;
            }
        }

        public string Bank
        {
            get
            {
                return bank;
            }
            set
            {
                if (value.Length <= 0) throw new Exception("band bank");
                bank = value;
            }
        }
        public override string ToString()
        {
            string u = Phone + " " + Seria + " " + Number + " " + Bank + " " + Password ;
            return u;
        }
    }
    
    
}