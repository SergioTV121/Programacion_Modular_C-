using System;


namespace Segundo
{
	
    class Program
    {
    	
        public static void Main(string[] args)
        {
Console.Title="Sergio Tinoco";

 char otro='s';
double longitud;
int cont=0;

        	
while (otro.Equals('s')||otro.Equals('S'))
{
            Console.WriteLine("Ingresa la longitud :  ");
         longitud=double.Parse(Console.ReadLine());
            
         if (longitud>=1.20&&longitud<=1.30)
         	
     cont++;
            
         
 Console.WriteLine("¿Otro perfil (Píeza)?");
 
 otro=Char.Parse(Console.ReadLine());
             

 
}
            
 	
      Console.WriteLine("Piezas aptas {0:f}",cont);     
      
            

            Console.ReadKey();

        }

    }

}