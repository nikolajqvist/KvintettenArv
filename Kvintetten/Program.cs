namespace Kvintetten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instrument World leggo!");

            /*Instrument saxofon = new Blowinstrument("Saxofon", "Saxofon. En saxofon er et transponerende instrument af" +
                " typen træblæser, selvom den normalt er lavet af messing. Den blev opfundet i 1840'erne af den belgiske instrumentbygger Adolphe Sax.");


            Console.WriteLine($"{saxofon.Description}");*/

            Instrument violin = new Violin("Violinen er et strygeinstrument med fire strenge, stemt i kvinter:" +
                " G, D1, A1 og E2, hvor A - strengen således stemmes i kammertonen.", 4);

            Console.WriteLine($"{violin.ToString()}");

            Instrument saxofone = new Saxofone("En saxofon er et transponerende instrument af typen træblæser, selvom den normalt er lavet af messing. " +
                "Den blev opfundet i 1840'erne af den belgiske instrumentbygger Adolphe Sax.");

            
            Console.WriteLine($"{saxofone.ToString()}");



            Console.ReadKey();
        }


    }
}
