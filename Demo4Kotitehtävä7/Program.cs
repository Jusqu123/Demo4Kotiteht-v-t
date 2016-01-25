using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4Kotitehtävä7
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();

            person.NickName = "Nickname: Johnny   ";
            person.Job = "Job: Singer   ";
            person.RealName = "Real Name: Bon jovi   ";
       
 
            Console.WriteLine(person.ToString());


            Jonne jonne = new Jonne("XxXEpicNicXxX", "test");
            jonne.Job = "Job: Troll   ";
            jonne.RealName = "Real Name: Viljami   ";
            jonne.NickName = "Nickname: XxXEpicNicXxX   ";
            jonne.Phrase = "Phrase: UMAD BRO   ";

            Console.WriteLine(jonne.ToString());


            Coder coder = new Coder("Kalle", "Koodari", "Linux");
            coder.Job = "Job: Student   ";
            coder.RealName = "Juuso   ";
            coder.NickName = "Jusqu123   ";
            coder.System = "Operating system: Linux   ";
      
            Console.WriteLine(coder.ToString());
            Console.WriteLine("press a key");
            Console.ReadLine();
        }
    }
}