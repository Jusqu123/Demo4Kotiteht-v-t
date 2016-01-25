using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Kotitehtävä7
{
    class Person
    {
        public string Job { get; set; }
        public string NickName { get; set; }
     
      
        public string RealName { get; set; }
  

        public Person()
        { }
        public Person(string nickName)
        {
            NickName = NickName;
          
        }
        public void PersonMethod()
        {
            Console.WriteLine("text area");
        }

        public override string ToString()
        {
            return Job + " "+ NickName + " "   + RealName + " " ;
        }
    }
}