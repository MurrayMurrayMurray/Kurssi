using System.Xml;


        namespace Ruoka_annos
    {
        internal class Program
        {
            enum P
            {
                nautaa,
                kanaa,
                kasvikset
            }
            enum L
            {
                perunaa,
                riisiä,
                pastaa
            }

            enum K
            {
                tomaatti,
                hapanimelä,
                pippuri,
                chili
            }
            static void Main(string[] args)
            {

                bool Oikein = false;


                string valinta = " ";
                P valittuP = P.kanaa;
                L valittuL = L.perunaa;
                K valittuK = K.hapanimelä;


                Console.SetCursorPosition(0, 2);
                Console.WriteLine("Tee annoksesi");
                Console.SetCursorPosition(0, 4);
                Console.WriteLine("Vaihto ehdot:");
                Console.SetCursorPosition(0, 6);
                string[] pääruoat = Enum.GetNames<P>();
                Console.Write("Pääruoka:");
                for (int i = 0; i < pääruoat.Length; i++)
                {
                    Console.Write($"{pääruoat[i]}, ");
                }
                Console.WriteLine();
                string[] lisukkeet = Enum.GetNames<L>();
                string[] kastikkeet = Enum.GetNames<K>();
                Console.WriteLine("Lisuke: perunaa, riisiä, pastaa");
                Console.WriteLine("Kastike: curry,hapanimelä,pippuri,chili");
                Console.SetCursorPosition(0, 10);
                Console.Write("Pääruoka? ");

                {
                    while (!Oikein)
                    {
                        valinta = Console.ReadLine();
                        for (int i = 0; i < pääruoat.Length; i++)
                        {
                            if (valinta == pääruoat[i])
                            {
                                Oikein = true;

                                Console.SetCursorPosition(0, 11);
                                valittuP = Enum.Parse<P>(valinta);
                                break;
                            }
                        }


                        if (!Oikein)
                        {
                            Console.SetCursorPosition(10, 10);
                            Console.Write("                               ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(10, 10);
                            Console.Write("Annosta ei löydy");
                            Thread.Sleep(800);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(10, 10);
                            Console.Write("                               ");
                            Console.SetCursorPosition(10, 10);
                        }
                    }

                    Console.WriteLine("Hyvä, mitä seuraavaksi?");
                    Console.Write("Lisuke ? ");
                    Oikein = false;


                    while (!Oikein)
                    {

                        valinta = Console.ReadLine();

                        for (int i = 0; i < lisukkeet.Length; i++)
                        {
                            if (valinta == lisukkeet[i])
                            {
                                Oikein = true;

                                Console.SetCursorPosition(0, 11);
                                valittuL = Enum.Parse<L>(valinta);
                                break;
                            }
                        }
                        Oikein = true;

                        Console.SetCursorPosition(0, 13);

                    }
                    if (!Oikein)
                    {

                        Console.SetCursorPosition(9, 12);
                        Console.Write("                               ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(9, 12);
                        Console.Write("Annosta ei löydy");
                        Thread.Sleep(800);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(9, 12);
                        Console.Write("                               ");
                        Console.SetCursorPosition(9, 12);
                    }
                }
                Console.WriteLine("Hyvä, ja lopuksi...");
                Console.WriteLine("Kastike?");
                Console.SetCursorPosition(9, 14);
                Oikein = false;
                while (!Oikein)
                {
                    valinta = Console.ReadLine();


                    for (int i = 0; i < kastikkeet.Length; i++)
                    {
                        if (valinta == kastikkeet[i])
                        {
                            Oikein = true;

                            Console.SetCursorPosition(0, 11);
                            valittuK = Enum.Parse<K>(valinta);
                            Oikein = true;

                            Console.SetCursorPosition(0, 16);

                            break;
                        }
                    }


                    if (!Oikein)
                    {
                        Console.SetCursorPosition(9, 14);
                        Console.Write("                               ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(9, 14);
                        Console.Write("Annosta ei löydy");
                        Thread.Sleep(800);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(9, 14);
                        Console.Write("                               ");
                        Console.SetCursorPosition(9, 14);
                    }
                }


                Console.WriteLine($"Kiitoksia, tässä tilauksesi: Pääruoka:{valittuP} Lisuke: {valittuL} Kastike: {valittuK} ");
            }




        }

    }

    //enum P{
    //    nautaa,
    //    kanaa,
    //    kasviksia,
    //}
    //enum L
    //{
    //    perunaa,
    //    riisiä,
    //    pastaa,
    //}
    //enum K
    //{
    //    pippuri,
    //    hapanimelä,
    //    chili,
    //    tomaatti,
    //}

    //static void Main(string[] args)
    //{

    //    bool Oikein = false;


    //    string valinta = " ";


    //    Console.WriteLine("Tervetuloa ravintolaan");
    //    // Luo uuden olion
    //    // jos olion arvoja ei aseta
    //    // ne ovat tyyppikohtaiset oletusarvot:
    //    // int : 0, float 0, enum : ensimmäinen arvo


    //    Console.WriteLine("Tee annoksesi");
    //    Console.WriteLine("Valitse pääraaka-aine");
    //    string[] pääruoat = Enum.GetNames<P>();
    //    Console.WriteLine("Pääruoka");
    //    for (int i = 0; i < pääruoat.Length; i++)
    //    {

    //        Console.WriteLine($"{pääruoat[i]}, ");

    //        WaitCallback waitCallback = null;
    //        char chapchap;
    //        OnXmlDictionaryReaderClose onXmlDictionaryReaderClose = CancellationTokenRegistration = null;
    //        sbyte qpoew;



    //    } 
    //    //if (valinta == pääruoat[i]) 
    //        {


    //    }
    //    Console.WriteLine();
    //            valinta = Console.ReadLine();



    //    // kirjoita vaihtoehdot : WriteLine
    //    // Lue vastaus : ReadLine
    //    // muuta Enum muotoon : Enum.TryParse
    //    // tallenna tilaukseen
    //    // jne..

    //}

