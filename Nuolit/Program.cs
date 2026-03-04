namespace Nuolit
{
    enum K
    {
        puu = 3,
        ruoste = 5,
        kivi = 50,
        
        
    }
    enum P
    {
        lehti = 0,
        ruostekärki = 1,
        Nahka = 5
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            bool OikeaVastaus = false;
            int MAX = 100;
            int MIN = 0;
            
            Console.WriteLine("Nuolen pituus? (60 - 100 cm)");
           
            while (!OikeaVastaus) { 

                
                string[] Kärjet = Enum.GetNames<K>();
                
                Console.WriteLine("Kärkien vaihtoehdot:");
                for (int i = 0; i < Kärjet.Length; i++ )
                    {
                    Console.Write($" {Kärjet [i]},");
                

                int Kärkivastaus = Convert.ToInt32(Console.ReadLine());
                }














                int Perä = Convert.ToInt32(Console.ReadLine());




            int Pituus = Convert.ToInt32(Console.ReadLine());




                if (Pituus >= 60 && Pituus <= 100)
                {
                OikeaVastaus = true;
                Console.WriteLine((Pituus * 0.05) + " Kultarahaa");
                }
               else
                {
                Console.WriteLine("Ei tuon mittaista saa ostaa? sano toinen luku (60 - 100)");
                 }







                                    }
        }
    }
}
