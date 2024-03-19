
using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;


namespace Aeroport
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            UserManager u = new UserManager();
            
            IsuService isuService = new IsuService(u);
            isuService.AddGroup(50, 5);
            isuService.AddBuyer("Andrei1994", "Zaur194","Andrei","Orlov",29,1000,"S75");
            Buyer b = isuService.FindBuyer("Andrei1994", "Zaur194", "Andrei", "Orlov", 29, 1000,"10");
            Console.WriteLine(b.Name);
            
            string input = Console.ReadLine();
            StreamWriter w = new StreamWriter("Password.txt");
            w.WriteLine(input);
            w.Close();
            StreamReader r = new StreamReader("password.txt");
            string t = r.ReadToEnd();
            r.Close();
            w.Close();
            
            var cipher = new Shifr();
            Console.Write("Введите пароль: ");
            var message = Console.ReadLine();
            Console.Write("Введите ключ: ");
            var secretKey = Convert.ToInt32(Console.ReadLine());
            var encryptedText = cipher.Encrypt(message, secretKey);
            Console.WriteLine("Зашифрованное сообщение: {0}", encryptedText);
            Console.WriteLine("Расшифрованное сообщение: {0}", cipher.Decrypt(encryptedText, secretKey));
            Console.ReadLine();
      
           
            

            
            var x = new Document();
            Console.Write("Ввведите серию и номер: ");
            var message1 = Console.ReadLine();
            Console.Write("Введите пароль: ");
            var pass = Console.ReadLine();
            var encryptedMessageByPass = x.Encrypt(message1, pass);
            Console.WriteLine("Зашифрованное сообщение {0}", encryptedMessageByPass);
            Console.WriteLine("Расшифрованное сообщение {0}", x.Decrypt(encryptedMessageByPass, pass));        
            Console.ReadLine();
            
            
            
            string str = "541312аеполр№»;4523673ьбтва932#@#467-0@";//вытаскивает из регурки телефон
            string reg = @"\d{7}";
            Console.Write("Строка: ");
            Console.WriteLine(str);
            Console.Write("Номера телефонов: ");
            foreach (Match s in Regex.Matches(str, reg))
            {
                string result = s.Value;
                for (int i = 0; i < s.Length; i++)
                {
                    if (i % 3 == 0 && i > 0)
                    {
                        Console.Write("-");
                    }
                    Console.Write(result[i]);
                }
            }


        }

      
        
    }
}