using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Kotitehtävä6
{
    class Opiskelija : Hylly
    {
        public bool Taidot { get; set; }
        public int Pullot { get; set; }
        public Opiskelija()
        {

        }
        public Opiskelija(int pelit, int kirja, bool kirjahylly, bool kitara)
            : base(pelit, kirja, kirjahylly, kitara)
        {
            Pullot = Pullot;
            Taidot = Taidot;
        }
        public override string ToString()
        {
            return base.ToString() + "    tyhjiä pulloja on hyllyssä : " + Pullot + "      kitaransoittotaidot :" + Taidot;
          
        }

    }
}