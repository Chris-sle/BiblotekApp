namespace ConsoleApp1
{
    internal class Biblotek
    {
        private List<Bok> ListeAvBøker = new List<Bok>();

        public void VisBiblotekInnhold()
        {
            Console.WriteLine("Bibloteket inneholder disse bøkene");
            Console.WriteLine();
            foreach (var bok in ListeAvBøker)
            {
                bok.ShowInfo();
                Console.WriteLine();
            }
        }
        public void AddBook(string navn, int utgivelsesÅr, string sjanger)
        {
            ListeAvBøker.Add(new Bok(navn, utgivelsesÅr, sjanger));
        }

        public void VisAvValgtSjanger(string valgtSjanger)
        {
            foreach (var bok in ListeAvBøker)
            {
                if (bok.Sjanger == valgtSjanger)
                {
                    bok.ShowInfo();
                }
            }
        }
    }
}
