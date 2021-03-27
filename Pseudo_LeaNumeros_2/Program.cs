using System;

namespace Pseudo_LeaNumeros_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un número entero de tres digitos");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

          
           if(num >99 && num<1000)
           {    
               num = num % 10;
               int num1 = num % 10;
               int num2 = num1 % 10;
              
               if (num!=num1 && num1 != num2 )
               {
                    Console.WriteLine("NO Existen  digitos iguales");
               }
               else if(num==num1 || num1 == num2 )
               {
                   Console.WriteLine("Existen 2 digitos iguales");
               }
               else if (num==num1 && num1 == num2)
               {
                   Console.WriteLine("Los 3 digitos son  iguales");
               }

                    
            }else 
            {
               Console.WriteLine("Debe digitar un numero que tenga 3 digitos");
           
        }
    }
}
