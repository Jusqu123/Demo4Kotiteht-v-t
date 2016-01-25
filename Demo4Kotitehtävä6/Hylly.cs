using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Kotitehtävä6
{
    class Hylly
    {

        public bool Kirjahylly { get; set; }

        public int Pelit { get; set; }

        public int Kirja { get; set; }

        public bool Kitara { get; set; }
     



        public Hylly()
        {


        }

        public Hylly(int pelit, int kirja, bool kirjahylly, bool kitara)

        {
            Pelit = pelit;

            Kirja = kirja;

            Kirjahylly = kirjahylly;

            Kitara = kitara;
         
        }


        public override string ToString()

        {

            return "   kirjahyllyn olemassaolo " + Kirjahylly + "    Pelejä: " + Pelit + "   Kirjoja  :" + Kirja + "        Onko hyllyssä Kitara : " + Kitara;

        }
    }
}