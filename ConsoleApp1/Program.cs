namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mittBiblotek = new Biblotek();

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Velg et valg: \n1 for å legge til en ny bok" +
                                  "\n2 for å vise biblotek" +
                                  "\n3 for å vise valgt sjanger" +
                                  "\nalt annet for å avslutte");
                var userReply = Console.ReadLine();

                if (userReply == "1")
                {
                    Console.WriteLine("Navn på bok?");
                    string BokNavn = Console.ReadLine();
                    Console.WriteLine("Når ble den gitt ut? angi Årstall.");
                    int BokUtgivelsesÅr = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sjanger på boken?");
                    string BokSjanger = Console.ReadLine();

                    mittBiblotek.AddBook(BokNavn, BokUtgivelsesÅr, BokSjanger);
                }
                else if (userReply == "2")
                {
                    mittBiblotek.VisBiblotekInnhold();
                    Console.ReadKey();
                }
                else if (userReply == "3")
                {
                    Console.WriteLine("Hvilken sjanger leiter du etter?");
                    string valgSjanger = Console.ReadLine();
                    mittBiblotek.VisAvValgtSjanger(valgSjanger);
                    Console.ReadKey();
                }
                else
                {
                    isRunning = false;
                }
            }
        }
    }
}
