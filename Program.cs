using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igraNaKarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int karte = 0;
            int CardCounter = 0;
            while (CardCounter < 31)
            {
                Console.WriteLine(" unesi kartu ");
                karte = Convert.ToInt32(Console.ReadLine());
                if(karte <= 13 && karte >= 1 )
                {
                    CardCounter += karte;
                    
                }
                else
                {
                    Console.WriteLine(" unjeli ste prevelik ili premali broj ");
                }
            }
            if(CardCounter == 31 )
                    {
                        Console.WriteLine(" POBJEDA!!!");
                    }
                    else
                    {
                        Console.WriteLine(" IZGUBILI STE :( ");
                    }
            Console.ReadKey();
        }
    }
}
