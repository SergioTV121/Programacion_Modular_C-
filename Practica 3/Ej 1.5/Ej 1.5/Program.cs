using System;


namespace Segundo
{
	
    class Program
    {
    	
        public static void Main(string[] args)
        {
Console.Title="Sergio Tinoco";

const int t=10;
float nota;

int cont=1,may6=0,men6=0;

        	
{


      for(cont=1;cont<=t;cont++)
      {
      
      
      Console.WriteLine(" Ingrese Nota {0} ",cont);
      nota=float.Parse(Console.ReadLine());
      
      if(nota>=6)
      	
      	may6++;
      else 
      	if(nota<6&&nota>=0)
      		men6++;
      
      
      
    
      }
      
      
      Console.WriteLine(" Las Notas Aprobatorias Fueron {0} y las reprobatorias fueron {1}",may6,men6);

            Console.ReadKey();

        }

    }

}
}