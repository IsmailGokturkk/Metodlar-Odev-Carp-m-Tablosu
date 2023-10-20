using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar_ODEV
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarpimTablosu(10);

            Console.ReadLine();
        }
    
    static void CarpimTablosu(int boyut)
            
        {
        
            for(int i=1;i<=boyut;i++)
            {
                for(int j = 1; j <= boyut; j++)
                {
                    Console.WriteLine(i + "*" + j + "="+ i * j);
                    
                }
                Console.WriteLine("\n");
            }
          
        
        
        
        
        }
    
    
    
    }
}
