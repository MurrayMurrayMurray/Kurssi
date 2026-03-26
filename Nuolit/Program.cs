namespace Nuolit
{
    public enum K
    {
        puu = 3,
        ruoste = 50,
        kivi = 5,


    }
    public enum S
    {
        lehti = 1,
        kalanevä = 10,
        fasaaninsulka = 5
    }
    internal class Program
    {




        // public float hinta = 0;
        static void Main(string[] args)
        {
            K ValittuKärki = K.puu;
            S ValittuSulka = S.lehti;
            int pituus = 0;

            /* float kokonaishinta = 0;
            
              */
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Valitse kärki (Puu, Ruoste, Kivi)");
            string kärkisyöte = Console.ReadLine().ToLower();
            if (kärkisyöte == "kivi") ValittuKärki = K.kivi;
            else if (kärkisyöte == "ruoste") ValittuKärki = K.ruoste;
            Console.WriteLine($"kärjeksi {ValittuKärki}, seuraavaksi?");

            Console.WriteLine("Valitse sulka (Lehti, Kalanevä, fasaaninsulka)");
            string sulkasyöte = Console.ReadLine().ToLower();
            if (sulkasyöte == "kalanevä") ValittuSulka = S.kalanevä;
            else if (sulkasyöte == "fasaaninsulka") ValittuSulka = S.fasaaninsulka;
            Console.WriteLine($"Sulaksi {ValittuSulka}, ja nuolen pituudeksi?");


            bool Oikein = false;

            // kysyy nuolen pituuden

            while (!Oikein)
            {
                Console.WriteLine("Nuolen pituus? (60 - 100 cm)");

                pituus = Convert.ToInt32(Console.ReadLine());




                if (pituus >= 60 && pituus <= 100)
                {

                    Oikein = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ei tuon mittaista saa ostaa?");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
                float kokonaishinta = (float)ValittuKärki + (float)ValittuSulka + (pituus * 0.05f);


                Console.WriteLine($"Nuolen pituus on {pituus} cm");
                Console.WriteLine($"Kärki: {ValittuKärki}, Sulka: {ValittuSulka}");
                Console.WriteLine($"Koko nuolen hinta: {kokonaishinta} kultarahaa");

            









            // }
        }
    }
}
