namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hotel = new Hotel();
            var reception = new Reception(hotel);
            var zimmer1 = new Zimmer();
            var zimmer2 = new Zimmer();
        }
    }
}