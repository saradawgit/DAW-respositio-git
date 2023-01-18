/*
// Alumna: Sara Reyes Grao 1º DAW Presencial 

// Ejercicio 1
using System;
public class reyesSara_examen
{
	public static void Main()
	{
		int n; 

		Console.Write("Introduce el lado del cuadrado: ");
		n = Convert.ToInt32(Console.ReadLine());

		int[,] lados = new int[n,n];

		for (int x = 0; x < n; x++)
		{
			for (int y = 0; y < n; y++)
			{
				lados[x,y] = x + y;
				Console.Write(" [{0}]", lados[x,y]);
			}
			Console.WriteLine();
		}
	}
}
*/

// Ejercicio 2
using System;
public class examen
{
	public static void Main()
	{
		ushort numero; 

		Console.Write("Introduce un número entero entre 1 y 9999: ");
		numero = Convert.ToUInt16(Console.ReadLine());

		if ((numero % 2 != 0) || (numero == 2))
			Console.WriteLine("El número {0} es primo", numero);
		else
		{
			Console.WriteLine("El número {0} no es primo y sus divisores son:", numero);
			for (int i = 1; i <= numero; i++)
			{
				if (numero % i == 0)
					Console.WriteLine(i);
			}
		}
	}
}

/*
// Ejercicio 3
using System;
public class examen
{
	struct datos
	{
		public int id;
		public string titulo;
		public string artista;
		public int duracion;
	}
	public static void Main()
	{
		datos[] queen = new datos[4];

		queen[0].id = 1;
		queen[0].titulo = "Bohemian";
		queen[0].artista = "Queen";
		queen[0].duracion = 300;

		queen[1].id = 2;
		queen[1].titulo = "Another";
		queen[1].artista = "Queen";
		queen[1].duracion = 180;

		queen[2].id = 3;
		queen[2].titulo = "Somebody";
		queen[2].artista = "Queen";
		queen[2].duracion = 240;

		queen[3].id = 4;
		queen[3].titulo = "Killer";
		queen[3].artista = "Queen";
		queen[3].duracion = 250;

		datos[] mecano = new datos[4];

		mecano[0].id = 1;
		mecano[0].titulo = "Cruz";
		mecano[0].artista = "Mecano";
		mecano[0].duracion = 500;

		mecano[1].id = 2;
		mecano[1].titulo = "Mujer";
		mecano[1].artista = "Mecano";
		mecano[1].duracion = 150;

		mecano[2].id = 3; 
		mecano[2].titulo = "Hawai";
		mecano[2].artista = "Mecano";
		mecano[2].duracion = 120;

		mecano[3].id = 4;
		mecano[3].titulo = "Otro anyo más";
		mecano[3].artista = "Mecano";
		mecano[3].duracion = 180;

		Console.WriteLine("La canción más largar de QUEEN es: "+ queen[0].titulo);
		Console.WriteLine("La canción más corta de MECANO es: " + mecano[2].titulo);

		int duracionQueen = queen[0].duracion + queen[1].duracion + queen[2].duracion + queen[3].duracion;
		int duracionMecano = mecano[0].duracion + mecano[1].duracion + mecano[2].duracion + mecano[3].duracion;


		if (duracionQueen > duracionMecano)
			Console.WriteLine("El álbum de QUEEN es el más largo");
		else 
			Console.WriteLine("¡El álbum de MECANO es el más largo!");
	}
}
*/