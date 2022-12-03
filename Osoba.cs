using System;
using System.Security.Cryptography.X509Certificates;

public class Osoba
{
   private string imie;
   private  double waga;
   private int wiek;
    private char plec;
   private double wzrost;

    public double zbialko;
    public double ztluszcze;
    public double zwelgowodany;

   public  double PPM;
    public Osoba()
	{
        System.Console.WriteLine("Podaj imie:");
        imie = Console.ReadLine();

        System.Console.WriteLine("Podaj wage:");
       waga = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Podaj wzrost:");
        wzrost = double.Parse(Console.ReadLine());




        System.Console.WriteLine("Podaj wiek:");
        wiek = int.Parse(Console.ReadLine());


        System.Console.WriteLine("Podaj płeć M/K:");
        plec =  char.Parse(Console.ReadLine());



        switch(plec)
        {
            case  'M':
                {
                    PPM = 66.47 + (13.7 * waga) + (5 * wzrost) - (6.74 * wiek);
                    zwelgowodany = (PPM * 0.45)/4;
                    zbialko = (PPM * 0.15)/4;
                    ztluszcze = (PPM * 0.2)/9;
                    break;
                }

            case 'K':
                {
                    PPM = 655.1 + (9.567 * waga) + (1.85 * wzrost) - (4.68 * wiek);
                    zwelgowodany = (PPM * 0.45) / 4;
                    zbialko = (PPM * 0.15) / 4;
                    ztluszcze = (PPM * 0.2) / 9;
                    break;
                }



            
        }


   
    

    }


    public void zapotrzebowanieKaloryczne()
    {
        Console.WriteLine(imie + " Potrzebuje jeszcze:");
        Console.WriteLine(zbialko + " g białka");
        Console.WriteLine(ztluszcze + " g tłuszczy");
        Console.WriteLine(zwelgowodany + " g węglowodanów");
        Console.WriteLine(PPM + " kcal");

    }

    public void zjedzDanie(double[] danie)
    {
        Console.WriteLine($"Po zjedzeniu {danie[0]} g posiłku");
        zwelgowodany -= danie[1];
        ztluszcze -= danie[2];
        zbialko -= danie[3];
        PPM -= danie[4];
        zapotrzebowanieKaloryczne();
    }
}
