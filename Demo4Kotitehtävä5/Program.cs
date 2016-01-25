using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Kotitehtävä5
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            int valinta = 0;

            while (valinta != 3)
            {

                Console.WriteLine("1. virtapainike");

                Console.WriteLine(" ");

                Console.WriteLine("2. Taajuuskorjain");
                Console.WriteLine(" ");

                Console.WriteLine("3. VolumeBar");

                Console.WriteLine(" ");

                Console.WriteLine("Press any key to crash this lousy program");
                Console.WriteLine();


                string numero = Console.ReadLine();
                valinta = int.Parse(numero);

                if (valinta == 1)
                {
                    radio.Virta = true; Console.WriteLine("painoit virtapainiketta");
                }



                if (valinta == 2 && radio.Virta == true)
                {
                    Console.Write("valitse haluamasi taajuus väliltä -> 2000.0-26 000.0 <- ");
                    string valinta2 = Console.ReadLine();
                    radio.Taajuus = double.Parse(valinta2);
                    Console.WriteLine("valitsit taajuuden :", radio.Taajuus);

                    if (valinta == 3 && radio.Virta == true)
                    {
                        Console.Write("Anna haluamasi äänenvoimakkuus väliltä 0-10  ");
                        string valinta3 = Console.ReadLine();
                        radio.Volume = int.Parse(valinta3);
                        Console.WriteLine("valitsit voimakkuuden : ");
                        Console.WriteLine(radio.Volume);
                    }
                }

            }
        }
    }
}