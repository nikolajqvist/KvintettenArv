using NAudio.Wave;

namespace Kvintetten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Strygeinstrument guitar = new Guitar("Guitaren er et knipset strengeinstrument normalt med seks strenge, men fire, syv, otte, ni, ti eller 12 (dobbeltkor) findes også. " +
                "Den oprindelige form er akustisk med en krop, der danner resonansbund for strengenes vibrationer.", 6);
            Console.WriteLine($"Description: {guitar.ToString()}");
            using (var audioFile = new AudioFileReader(@"C:\Users\nqvis\OneDrive\Skrivebord\Datamatiker\Pariprogramming\Kvintetten\Kvintetten\Kvintetten\Assets\guitar.wav"))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
            Thread.Sleep(2000);

            Instrument piano = new Piano("Et klaver er et musikinstrument der sammen med flygelet også kaldes for piano (kort form af pianoforte – italiensk for \"stille kraftigt\")." +
                " Et klaver består af et klaviatur, der med tangenter får filtbeklædte hamre til at anslå stemte strenge.");

            Console.WriteLine($"Description: {piano.ToString()}");
            using (var audioFile = new AudioFileReader(@"C:\Users\nqvis\OneDrive\Skrivebord\Datamatiker\Pariprogramming\Kvintetten\Kvintetten\Kvintetten\Assets\piano.wav"))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
            Thread.Sleep(2000);
            Instrument drum = new Drum("En tromme er et percussionsinstrument, eller slagtøj om man vil. Trommen er som oftest cylinderformet. " +
                "Der er udspændt skind eller et andet elastisk materiale ud over den ene ende af cylinderen.");
            Console.WriteLine($"Description: {drum.ToString()}");
            using (var audioFile = new AudioFileReader(@"C:\Users\nqvis\OneDrive\Skrivebord\Datamatiker\Pariprogramming\Kvintetten\Kvintetten\Kvintetten\Assets\drum.wav"))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
            Thread.Sleep(2000);

            Instrument saxofone = new Saxofone("En saxofon er et transponerende instrument af typen træblæser, selvom den normalt er lavet af messing. " +
              "Den blev opfundet i 1840'erne af den belgiske instrumentbygger Adolphe Sax.");


            Console.WriteLine($"{saxofone.ToString()}");

            using (var audioFile = new AudioFileReader(@"C:\Users\nqvis\OneDrive\Skrivebord\Datamatiker\Pariprogramming\Kvintetten\Kvintetten\Kvintetten\Assets\sax.wav"))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
            Console.ReadKey();
            Instrument violin = new Violin("Violinen er et strygeinstrument med fire strenge, stemt i kvinter:" +
               " G, D1, A1 og E2, hvor A - strengen således stemmes i kammertonen.", 4);

            Console.WriteLine($"{violin.ToString()}");

            using (var audioFile = new AudioFileReader(@"C:\Users\nqvis\OneDrive\Skrivebord\Datamatiker\Pariprogramming\Kvintetten\Kvintetten\Kvintetten\Assets\violin.wav"))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(1000);
                }
            }
            Console.ReadKey();
        }


    }
}
