using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Kotitehtävä7
{
    class Coder : Person
    {
        public string System { get; set; }


        public Coder()
        {

        }
        public Coder(string nickname, string Lastname, string system)
            : base(nickname)
        {
            System = system;
        }
        public void StudentMethod()
        {
            Console.WriteLine("student uses C# to code.");
        }

        public override string ToString()
        {
            return base.ToString() + " " + System;
        }
    }
}