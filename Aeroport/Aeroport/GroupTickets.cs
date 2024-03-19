namespace Aeroport
{
    public class GroupTickets//проверка покупок аэрофлота и аэрофлота плюс s7
    {
        private int x;
        private int y;

        public GroupTickets(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string Tickets
        {
            get
            {
                if (y >= 10)
                {
                    return "Aeroflot" + x + y;
                }
                else
                {
                    return "Aeroflot" + "S7" + y;
                }
            }
        }
    }
}