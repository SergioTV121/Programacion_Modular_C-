using System;


namespace Segundo
{
	
	class Program
	{
    
	
    	
	public static void Main(string[]args)
        { 
Console.Title= "Sergio Tinoco";




char otro;
int edad=0,acum=0,acum2=0;
float mayor=0,menor=200;
	{


do{

		
      Console.WriteLine("Ingrese la Edad: ");
      edad=int.Parse(Console.ReadLine());
      
    
      
      if(edad>mayor)
      	mayor=edad;
      
 
 
      if(edad<menor)
      {
   
      	menor=edad;


      }
      
      
      if(edad>=18)
      {
      	acum=acum+1;
      }
      else
      	if(edad<18)
      		acum2=acum2+1;
      
      
      
      Console.WriteLine(" ¿Otra Edad?  S/N ");
      otro=char.Parse(Console.ReadLine());   

      
}while (otro=='S'||otro=='s');

     
      
Console.WriteLine(" El numero de personas mayores de edad  es: {0} \n Y el de menores de edad es: {1} ",acum,acum2);
            
Console.WriteLine(" La Mayor edad Ingresada fue:  {0} \n Y la menor fue: {1} años",mayor,menor);


            Console.ReadKey();

		}
        }
	}
}