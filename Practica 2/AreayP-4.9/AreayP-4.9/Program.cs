using System;

namespace areayaltura2
{
    class Program
    {
        public static void Main(string[] args)
        {

        	float b, h, area, perimetro;
        	
        	
            Console.WriteLine("Ingresa la Base del rectangulo:  ");
            b=float.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Ingresa la Altura del rectangulo:  ");
            h=float.Parse(Console.ReadLine());
            
            area=b*h;
            
            perimetro=2*(b+h);
            	
            	
            Console.WriteLine("El Area del rectuangulo es: {0:f2} y el perimetro es: {1:f2} ", area,perimetro);
      
            

            Console.ReadKey();

        }

    }

}