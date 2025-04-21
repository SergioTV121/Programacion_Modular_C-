
using System;

namespace ej_4_ver_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Title="Sergio Tinoco";
			
			float din, cont=0;
			string nombre;

	do{
	Console.WriteLine("Ingrese nombre del usuario:");
	nombre=Console.ReadLine();
	Console.WriteLine("Ingrese cantidad de dinero:");
	din=float.Parse(Console.ReadLine());

	if(din>0 || din<0)
	{
		if (din>0)
		{
			Console.WriteLine("Nombre: {0}\nSaldo: {1}\nEstado de la cuenta: Acreedor", nombre,din);
			cont=cont+din;
		}
		else
			Console.WriteLine("Nombre: {0}\nSaldo: {1}\nEstado de la cuenta: Deudor", nombre,din);
	}
	else
			Console.WriteLine("Nombre: {0}\nSaldo: {1}\nEstado de la cuenta: Nulo", nombre,din);
	Console.WriteLine ();
}while(din>-1);
			
			Console.WriteLine("Sumatoria de saldos acreedores: {0}", cont);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}