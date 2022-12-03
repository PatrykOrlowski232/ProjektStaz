using System;

public class Skladnik
{
    

		public string nazwa;
		public double objetosc;
		public double weglowodany;
		public double tluszcze;
		public double bialko;
		public double kcal;




		public Skladnik(string nazwa, double objetosc, double weglowodany, double tluszcze, double bialko, double kcal)
		{
			 double licznik = objetosc / 100;
			this.nazwa = nazwa;
			this.objetosc = objetosc;
			this.weglowodany = Math.Round((weglowodany * licznik),2);
			this.bialko = Math.Round((bialko * licznik),2);
			this.tluszcze = Math.Round((tluszcze * licznik),2);
			this.kcal = Math.Round((kcal * licznik),2);
		}
    public Skladnik()
    {
		Console.WriteLine("Podaj nazwe składnika");
		nazwa = Console.ReadLine();
        Console.WriteLine("Waga składnika");
		objetosc = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj węglowodany na 100g składnika");
		weglowodany = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj białko na 100g składnika");
		bialko = double.Parse(Console.ReadLine());	
        Console.WriteLine("Podaj tłuszcze na 100g składnika");
		tluszcze = double.Parse(Console.ReadLine());	
        Console.WriteLine("Podaj kcal na 100g składnika");
		kcal = double.Parse(Console.ReadLine());	


    }

    public void makroElementy()
		{
			

			System.Console.WriteLine("W " + objetosc + " g " + nazwa +  " mamy :");
			System.Console.WriteLine(" weglowodany:" + Math.Round(weglowodany,2) + " \n białko " + Math.Round(bialko,2));
			System.Console.WriteLine( "tłuszcze: " + Math.Round(tluszcze,2) + " \n" + " kcal:" + Math.Round(kcal,2));

		}

	public static	  double[] stworzDanie(Skladnik[] skladniki)
	{


        double[] danie = new double[5];

        for (int i = 0; i < skladniki.Length; i++)
        {
			if (skladniki[i] != null)
			{
				danie[0] += skladniki[i].objetosc;
				danie[1] += skladniki[i].weglowodany;
				danie[2] += skladniki[i].tluszcze;
				danie[3] += skladniki[i].bialko;
				danie[4] += skladniki[i].kcal;
			}
        }
        return danie;

    }

	public static int ileSkladnikowNiePustych(Skladnik[]skladniki)
	{
		int liczba = 0;

		for(int i = 0; i < skladniki.Length; i++)
		{
			if (skladniki[i] != null)
				liczba++;


		}
		return liczba;
	}



}

