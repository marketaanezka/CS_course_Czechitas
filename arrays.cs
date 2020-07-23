using System;
public class Program
{
	public static void Main()
	{
		// 1. Vytvor tridu "Zena" a v ni dve vlastnosti: "Jmeno" a "Vlastnost"
		// muj kod, nemenit
		string[] vlastnosti = new string[]{"laskava", "hodna", "mila", "vesela", "vsetecna", "bohata", "uspesna", "bezstarostna", "talentovana"};
		string[] jmena = new string[]{"Bara", "Karolina", "Lucie", "Zaneta", "Jana", "Katka", "Martina", "Veronika", "Kamila"};
		// ty zacinas pracovat zde, ale zacni prikladem 1 vespod
		
		// 2. vytvor pole "zeny" o delce 9, kam budes ukladat objekty vytvorene ze tridy Zena
		
		Zena[] zeny = new Zena[9];
		// 3. vytvor cyklus o deviti opakovanich, kde v kazde iteraci vytvoris novy objekt podle tridy Zena
		// a do jeho vlastnosti "Jmeno" priradis jmeno z pole "jmena" a do vlastnosti "Vlastnost" hodnotu z pole "vlastnosti" tak, aby kazda z zen mela jine jmeno a jinou vlastnost
		// zaroven ale prvni zena bude mit posledni vlastnost a posledni zena prvni vlastnost, tedy Bara bude zla a Kamila laskava
		// kazdou vytvorenou zenu vloz do pole "zeny", ktere jsi vytvorila tak, ze prvni vytvorena pujde nakonec a posledni vytvorena na zacatek
		
		int jmeno = 0;
		for (int i = zeny.Length - 1; i >= 0; i--)
		{
			zeny[i] = new Zena(jmena[jmeno], vlastnosti[i]);
			jmeno++;
		}

		// 4. vypis obsah pole "zeny"
		for (int i = 0; i < zeny.Length; i++)
		{
			Console.WriteLine("{0} je {1}.", zeny[i].Jmeno, zeny[i].Vlastnost);
		}

		// nasleduje muj kod, nic tam nemen ... vsechny vypisy by mely vracet true
		Console.WriteLine("Mame 9 zen. " + (zeny.Length == vlastnosti.Length));
		Console.WriteLine("Prvni zena se jmenuje Kamila. " + (zeny[0].Jmeno == jmena[jmena.Length - 1]));
		Console.WriteLine("Posledni zena se jmenuje Bara. " + (zeny[zeny.Length - 1].Jmeno == jmena[0]));
		Console.WriteLine("Kamila je laskava. " + (zeny[0].Vlastnost == vlastnosti[0]));
		Console.WriteLine("Bara je talentovana. " + (zeny[zeny.Length - 1].Vlastnost == vlastnosti[vlastnosti.Length - 1]));
	}
}

class Zena
{
	public string Jmeno;
	public string Vlastnost;
	public Zena(string jmeno, string vlastnost)
	{
		Jmeno = jmeno;
		Vlastnost = vlastnost;
	}
}

