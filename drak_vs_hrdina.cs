using System;
					
public class Program
{
	public static void Main()
        {
            /*

            Vitej ve hre Hrdina vs Drak. Tento priklad je opakovani na OOP (objektove orientovane programovani)
            a tvym ukolem je doplnit tridy pro draka a hrdinu tak, aby tento kod fungoval. V kodu, ktery jsem napsal,
            vubec nic nemen! Tvym cilem take je, aby vsechny konzolove vypisy v tomto programu do konzole vypisovaly True.
            Prijemnou zabavu :-)

            */

            Drak zabijak = new Drak(100);

            Console.WriteLine("Kontrola:\nDrak ma 100 zivotu? {0}\n", zabijak.PocetZivotu == 100);

            Hrdina borec = new Hrdina();
            borec.VelikostUtoku = 5;

            int pocetKol = 0;
            while (zabijak.JeZivy())
            {
                borec.Zasahni(zabijak);
                pocetKol++;
            }

            Console.WriteLine("Hrdina zabil draka.\nKontrola:\nDrak nema zadny zivot? {0}", zabijak.PocetZivotu == 0);
            Console.WriteLine("Bylo odehrano presne 20 kol? {0}", pocetKol == 20);

            /*
             class Drak
                vlastnost PocetZivotu / int = rovnou jako vstup do konstruktoru 
                jeZivy metoda / bool / podminka kontroluje jestli 
                
            class Hrdina
                vlastnost velikost utoku / int
                metoda Zasahni = pocetyivotu minus silautoku 

             */

        }
    }

    class Drak
    {
        public int PocetZivotu;
        public Drak(int pocetZivotu)
        {
            PocetZivotu = pocetZivotu;
        }

        public bool JeZivy()
        {
           return PocetZivotu > 0;
        }
    }

    class Hrdina
    {
        public int VelikostUtoku;
        public void Zasahni(Drak zbyvajiciZivoty)
        {
            zbyvajiciZivoty.PocetZivotu -= VelikostUtoku;
        }
        
    }


