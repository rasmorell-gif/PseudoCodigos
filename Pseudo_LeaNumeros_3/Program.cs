using System;

namespace Pseudo_LeaNumeros_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un número entero ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int count = 0;

          for(int i = 0; i > num / 2 ;)
          {
             if(num / 2 != 0 ) 
             {
                 count++;
             }
          } Console.WriteLine($"Los pares contenidos en {num} son {count}");                
            }else 
            
               Console.WriteLine("");
             }
           
        }
    }
}
