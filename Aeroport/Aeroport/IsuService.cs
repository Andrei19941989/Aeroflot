using System;
using System.Collections.Generic;
namespace Aeroport
{
    public class IsuService//управляет этими группами и покупателями
    {
        private UserManager u;
        private List<Group> groups;

        public IsuService(UserManager u)
        {
            groups = new List<Group>();
            this.u = u;
        }

        public void AddGroup(int money, int count)
        {
            Group g = new Group(money, count);
            
                groups.Add(g);
            
                
        }
        

        public Group FindGroup(string groupTickets)
        {
            for (int i = 0; i < groups.Count; i++)
            {

            
                if (groups[i].GroupTickets.Contains(groupTickets) )
                {
                    return groups[i];
                }
            }
     
            return null;

        }

        public void AddBuyer(string login,string password,string name, string surname, int age, int coin, string groupTickets)
        {
            Group g = FindGroup(groupTickets);
            Buyer b = new Buyer(login,password,name, surname, age, coin);
            g.Add(b);
            u.Create(login,password,name,surname,age,coin);
        }

        public Buyer FindBuyer(string login, string password, string name, string surname, int age, int coin, string s)
        {
            for (int i = 0; i < groups.Count; i++)
            {
                Buyer b = groups[i].Find(login,password,name,surname,age,coin);
                if (b != null)
                {
                    return b;
                }
            }

            return null;
        }

      
    }
}
