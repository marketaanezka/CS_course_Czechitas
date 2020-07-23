using System;

public class Program
{
	public static void Main()
	{
		Zvire[] zoo = new Zvire[6];
		zoo[0] = new Zvire("zelva", 500, 5);
		zoo[1] = new Zvire("tucnak", 10, 10);
		zoo[2] = new Zvire("delfin", 85, 60);
		zoo[3] = new Zvire("hroch", 1000, 30);
		zoo[4] = new Zvire("sokol", 1, 300);
		zoo[5] = new Zvire("gepard", 50, 120);
		Console.WriteLine("V Zoo máme řadu zvířat.");
		// for (int i = 0; i< zoo.Length; i++)
		// {
		//     Console.Write(zoo[i].Druh + ", ");
		// }
		//ukol a)
		double suma = 0;
		for (int i = 0; i < zoo.Length; i++)
		{
			suma += zoo[i].Hmotnost;
		}

		Console.WriteLine();
		Console.WriteLine("Jejich průměrná hmotnost je: {0}", suma / zoo.Length);
		//ukol b)
		bool jeTuZirafa = false;
		for (int i = 0; i < zoo.Length; i++)
		{
			if (zoo[i].Druh == "zirafa")
			{
				Console.WriteLine("Je mezi nimi i žirafa.");
				jeTuZirafa = true;
			}
		}

		if (jeTuZirafa == false)
		{
			Console.WriteLine("Žirafa mezi nimi není.");
		}

		//ukol c)
		int defaultniIndex = 0;
		for (int i = 1; i < zoo.Length; i++)
		{
			if (zoo[defaultniIndex].Rychlost < zoo[i].Rychlost)
			{
				defaultniIndex = i;
			}
		}

		Console.WriteLine("Nejrychlejší ze všech je {0}, dosahuje rychlosti až {1} km/h!", zoo[defaultniIndex].Druh, zoo[defaultniIndex].Rychlost);
		//ukol d)
		for (int i = 0; i < zoo.Length; i++)
		{
			if (zoo[i].Hmotnost > 100)
			{
				Console.WriteLine("A {0} je jedno z nejtěžších zvířat v naší zoo, může vážit klidně {1} kilogramů.", zoo[i].Druh, zoo[i].Hmotnost);
			}
		}

		//ukol extra - srovnani vahy,bez pomocneho jsem na to neprisla :{             
		int srovnavaciIndex = 0;
		for (int i = 0; i < zoo.Length; i++)
		{
			//prisla jsem na nested for cycle pro porovnani vsech se vsemi, 
			for (int i2 = i + 1; i2 < zoo.Length; i2++)
			{
				// a tu vymenu hodnot na indexech jsem pochopila pak po dalsim studiu tematiky
				if (zoo[i].Hmotnost > zoo[i2].Hmotnost)
				{
					srovnavaciIndex = zoo[i].Hmotnost;
					zoo[i].Hmotnost = zoo[i2].Hmotnost;
					zoo[i2].Hmotnost = srovnavaciIndex;
				}
			}
		}

		//bohužel toto vymění jen hodnoty váhy, ne zvířata jako taková :(
		Console.WriteLine("Pokud seřadíme naši zoo podle hmonosti, vyjde nám, že máme zvířata o váze:");
		for (int i = 0; i < zoo.Length; i++)
		{
			Console.Write(zoo[i].Hmotnost + ", ");
		}
	}

	class Zvire
	{
		public string Druh;
		public int Hmotnost;
		public int Rychlost;
		public Zvire(string druh, int hmotnost, int rychlost)
		{
			Druh = druh;
			Hmotnost = hmotnost;
			Rychlost = rychlost;
		}
	}
}

