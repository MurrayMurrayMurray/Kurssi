namespace Nuoli
{
    enum Tilat
        {
        Auki,
        Kiinni,
        Lukossa,
        LukkoAuki

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitä haluat tehdä ovella?");
            string[] OvenTilat = Enum.GetNames<Tilat>();
            Console.WriteLine("vaihtoehdot:");
            for (int i = 0; i < OvenTilat.Length; i++)
            {
                Console.Write($" {OvenTilat[i]},");
            }
        }
    }
}
