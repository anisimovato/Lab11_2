using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab11uravn;

namespace Lab11HomeW
{
    class Program
    {
        static void Main(string[] args)
        {
            Uravnenie uravnenie = new Uravnenie(60, 20);
            uravnenie.X();
            Console.ReadKey();
        }
        
    }
}
