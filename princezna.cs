using System;
					
public class Program
{
	public static void Main()
	{
		SipkovaPrincezna princezna = new SipkovaPrincezna();
		princezna.Spi = true;
		
		// vytvori novy generator nahodnych cisel a rovnou vygeneruje cislo od 0 do 0.99 a pak vynasobi 100
		double nahodneMnozstviKrovi = new Random().NextDouble() * 100;
		ZarostlaVez vez = new ZarostlaVez(nahodneMnozstviKrovi);		
		
		Console.WriteLine("Kontrola:\nVez je dostatecne zarostla {0}", vez.MnozstviTrni == nahodneMnozstviKrovi);
		
		StatecnyPrinc princ = new StatecnyPrinc();
		princ.DelkaMece = 5.2;
				
		while (vez.JeZarostla())
		{
			princ.MachniMecem(vez);			
		}			
		
		Console.WriteLine("Princ se prosekal trnim.\nKontrola:\nUz neni co sekat? {0}", vez.MnozstviTrni <= 0);
		Console.WriteLine("Vyhnul se princ sekání do kamene? {0}", vez.MnozstviTrni == 0);
		Console.WriteLine("Sipkova princezna porad chrni? {0}", princezna.Spi);
		
		princ.Polib(princezna);
		
		Console.WriteLine("Sipkova princezna se uz probrala? {0}", !princezna.Spi);
		Console.WriteLine("Bude svatba. Konec pohadky.");
	}
	
	  class SipkovaPrincezna
    {
        public bool Spi;
    }

    class ZarostlaVez
    {
        public double MnozstviTrni;
       
        public ZarostlaVez(double mnozstviKrovi)
        {
            MnozstviTrni = mnozstviKrovi;
        } 
        public bool JeZarostla()
        {
            if (MnozstviTrni > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    class StatecnyPrinc
    {
        public double DelkaMece;
        public void MachniMecem (ZarostlaVez pohadkova)
        {
            if (pohadkova.MnozstviTrni > DelkaMece)
            { 
            pohadkova.MnozstviTrni -= DelkaMece;
            }
            else
            {
                pohadkova.MnozstviTrni = 0;
            }

        }

        public void Polib (SipkovaPrincezna Belinka)
        {
            Console.WriteLine("mlaskkk");
            Belinka.Spi = false;
        }
    }
}

