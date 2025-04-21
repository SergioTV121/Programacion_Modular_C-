using System;


namespace Segundo
{
	
	class Program
	{
    
	
    	
		public static void Main(string[]args)
        { 
Console.Title= "Sergio Tinoco";




char otro;
string Nombre,Nmayor,Nmenor;
int edad,Emayor=0,Emenor=0;
float mayor=0,menor=100;
	{

		Nmayor=(Console.ReadLine());
		Nmenor=Nmayor;
do{

	 Console.WriteLine(" Ingrese el Nombre: ");
      Nombre=(Console.ReadLine());	
			
			
      Console.WriteLine(" Ingrese la Edad: ");
      edad=int.Parse(Console.ReadLine());
      
    
      
      if(edad>mayor)
      {
     
      	mayor=edad;
      	Nmayor=Nombre;
      	Emayor=edad;
      }
 
      else
      if(edad<menor)
      {
   
      	menor=edad;
      	Nmenor=Nombre;
      	Emenor=edad;
      }
      
      Console.WriteLine(" ¿Otra Edad?  S/N ");
      otro=char.Parse(Console.ReadLine());   

      
}while (otro=='S'||otro=='s');

     
      
		

            Console.WriteLine(" La Persona mas grande es {0} y tiene {1} años",Nmayor,Emayor);
            
            
                        Console.WriteLine(" La Persona mas joven es {0} y tiene {1} años",Nmenor,Emenor);


            Console.ReadKey();

		}
        }
	}
}