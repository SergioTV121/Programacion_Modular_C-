using System;


namespace Segundo

{
	class Program
	{
    
	
    	
	public static void Main(string[]args)
        { 
Console.Title= "Sergio Tinoco";




int n=0,x=0;
double s=1;
	{

		
      Console.WriteLine("Ingrese numero entero positivo: ");
      n=int.Parse(Console.ReadLine());
      
      if(n>0)
      {
      	for(x=2;x<=n;x++){
      	
      		s=s+(1/Math.Pow(x,3));
      	}
      	




      

     
      
Console.WriteLine(" El resultado de la Operacion es: {0} ",s);
            
      }
  
      	if(n<1){
Console.WriteLine("Valor no compatible con la operacion");
      	}


            Console.ReadKey();

	
        
	}
}
}

}