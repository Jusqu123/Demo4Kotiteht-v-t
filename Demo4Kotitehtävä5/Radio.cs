using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Kotitehtävä5
{

    class Radio
    {

        private double maxTaajuus = 26000.0;

        private double minTaajuus = 2000.0;


        private double taajuus;



        private int volume;


        public bool Virta { get; set; }









        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= Volume && value >= Volume) volume = value;
                else
                {
                    Console.WriteLine("Learn to read ");

                }
            }
        }





        public double Taajuus
        {
            get
            {
                return taajuus;
            }
            set
            {
                if (value <= maxTaajuus && value >= minTaajuus) taajuus = value;

            }
        }


    }
}