using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Kotitehtävä6
{      class Program
        {
            static void Main(string[] args)
        {


            Opiskelija opiskelija = new Opiskelija();

            opiskelija.Kirjahylly = true;

            opiskelija.Pelit = 87;

            opiskelija.Kirja = 2;

            opiskelija.Pullot = 13;

            opiskelija.Kitara = true;

            opiskelija.Taidot = false;



                Console.Write("opiskelijan hyllyn sisätlö ");
                Console.WriteLine(" ");
                Console.WriteLine(opiskelija.ToString());

        }
        }
        }