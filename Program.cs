namespace Objects_and_External_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DodataKlasa PrviObjekat = new DodataKlasa();
            Console.WriteLine(PrviObjekat.x);
            Console.WriteLine(PrviObjekat.NekiString);
            Console.WriteLine(PrviObjekat.NekiChar);

            Console.WriteLine("##########");

                DodataKlasa StotiObjekat = new DodataKlasa();
            Console.WriteLine(StotiObjekat.x);
            Console.WriteLine(StotiObjekat.NekiString);
            Console.WriteLine(StotiObjekat.NekiChar);
        }
    }
}
