using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Kotitehtävä7
{
    class Jonne : Person
    {
        public string Phrase { get; set; }

        public Jonne()
        {

        }
        public Jonne(string nickname, string Phrase)
            : base(nickname)
        {
  
        }
        public void TeacherMethod()
        {
            Console.WriteLine("textarea");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Phrase;
        }
    }
}