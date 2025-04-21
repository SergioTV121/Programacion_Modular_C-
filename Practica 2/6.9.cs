using System;

namespace areayaltura2
{
    class Program
    {
        public static void Main(string[] args)
        {

        	float cantconv, euros;
        	
        	Console.ForegroundColor=ConsoleColor.Cyan;
        	      Console.BackgroundColor=ConsoleColor.Black;
        	        Console.Clear ();
        	
        	
            Console.WriteLine("Ingrese cantidad de marcos: ");
            cantconv=float.Parse(Console.ReadLine());
            
            euros=(cantconv/12.2f)*1.09f;
            	
      
            Console.WriteLine("{0:f2} marcos son {1:f2} euros",cantconv,euros);
      
            

            Console.ReadKey();

        }

    }

}