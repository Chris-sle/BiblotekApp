namespace ConsoleApp1
{
    internal class Bok
    {
        public string Navn { get; private set; }
        public int UtgivelsesÅr { get; private set; }

        public string Sjanger { get; private set; }

        public Bok(string name, int utgivelsesÅr, string sjanger)
        {
            Navn = name;
            UtgivelsesÅr = utgivelsesÅr;
            Sjanger = sjanger;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Navn: " + Navn + "\nUtgivelses år: " + UtgivelsesÅr + "\nSjanger: " + Sjanger);
        }
    }
}
