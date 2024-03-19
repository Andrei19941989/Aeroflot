using System.Collections.Generic;
namespace Aeroport

{
    public class Group//покупателя которые приобрели одну из билетов аэрофлот и s7
    {
        private GroupTickets g;
        private List<Buyer> buyers;

        public Group(int money, int count)
        {
            g = new GroupTickets(money, count);
            buyers = new List<Buyer>();
        }

        public string GroupTickets
        {
            get
            {
                return g.Tickets;
            }
        }

        public void Add(Buyer b)
        {
            buyers.Add(b);
        }

        public Buyer Find(string login,string password,string name, string surname, int age, int coin)
        {
            for (int i = 0; i < buyers.Count; i++)
            {
                if (buyers[i].Login.Equals(login) && buyers[i].Password.Equals(password) && buyers[i].Name.Equals(name) && buyers[i].Surname.Equals(surname) && buyers[i].Age == age &&
                    buyers[i].Coin == coin)
                {
                    return buyers[i];

                }
            }

            return null; 
        }

        public void Remove(Buyer b)
        {
            buyers.Remove(b);
        }

        public void Remove(string login,string password,string name, string surname, int age, int coin)
        {
            Buyer b = Find(login,password,name,surname,age,coin);
            Remove(b);
        }
        
    }
}