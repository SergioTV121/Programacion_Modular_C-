using System;

namespace areayaltura2
{
    class Program
    {
        public static void Main(string[] args)
        {

        	float cantconv, euros;
        	
        	
            Console.WriteLine("Ingrese cantidad de pesos: ");
            cantconv=float.Parse(Console.ReadLine());
            
            euros=(cantconv/22.5f)*1.09f;
            	
      
            Console.WriteLine("{0:f2} pesos son {1:f2} euros",cantconv,euros);
      
            

            Console.ReadKey();

        }

    }

}