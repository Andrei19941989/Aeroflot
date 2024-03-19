using System;
using System.Collections.Generic;

namespace Aeroport
{
    public class Admin//класс админа который проверяет работаспобсоность сайта-в данном случае паролей сотрудников и сами данные
    {
        private string phone;
        private string seria;
        private string number;

        public Admin(string Phone, string Seria, string Number)
        {
            this.Phone = Phone;
            this.Seria = Seria;
            this.Number = Number;
        }

   


        public string Phone
        {
            get
            { 
                return phone;
            }
            set
            {
                if (value.Length >10) throw new Exception("error phone");
                phone = value;
            }
        }

        public string Seria
        {
            get
            {
                return seria;
            }
            set
            {
                if (value.Length > 4) throw new Exception("bad seria");
                seria = value;
            }
        }

        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value.Length > 6) throw new Exception("bad number");
                number = value;
            }
        }
        
        public override string ToString()
        {
            string d = phone + " " + seria + " " + number;
            return d;
        }
        

        //генератор повторений пароля
        private string GetRepeatKey(string s, int n)
        {
            var r = s;
            while (r.Length < n)
            {
                r += r;
            }

            return r.Substring(0, n);
        }

      
        

    }

}
