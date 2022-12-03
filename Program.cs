// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System.Security.Cryptography.X509Certificates;

public class main
{
    public static void Main(string[] args)
    {


        Osoba a = new Osoba();


        Skladnik[] skladniki = new Skladnik[50];
        Skladnik[] skladnikiNaDanie = new Skladnik[50];

        double[] danie = new double[5];
        skladniki[0] = new("kurczak", 110, 0, 1, 22, 230);
        skladniki[1] = new("ziemniak ", 250, 17, 0, 2, 77);
        skladniki[2] = new("losos ", 100, 0, 14, 20, 201);
        skladniki[3] = new("surówka ", 150, 0, 14, 20, 201);



        while (true)
        {
            menu();

        }




        void menu()
        {
            Console.Clear();
            System.Console.WriteLine("Co chcesz zrobić(jeżeli chcesz wyjść wciśnij q) ?");
            System.Console.WriteLine("1.Przejrzeć liste produktów");
            System.Console.WriteLine("2.Dodać produkt");
            System.Console.WriteLine("3.Dodać produkt do Dania");
            System.Console.WriteLine("4.Zrobić Danie");
            System.Console.WriteLine("5.Zatwierdzić zrobiony posiłek");
            System.Console.WriteLine("6.Sprawdzić swoje Zapotrzebowanie kaloryczne");

            char wybor = char.Parse(System.Console.ReadLine());
            int wybor2;
            switch (wybor)
            {
                case '1':
                    {
                        for (int i = 0; i < skladniki.Length; i++)
                        {
                            if (skladniki[i] != null)
                            {
                                Console.WriteLine(i + ". " + skladniki[i].nazwa + " " + skladniki[i].objetosc + "g B:" +
                                    skladniki[i].bialko + " W:" + skladniki[i].weglowodany + " T:" + skladniki[i].tluszcze +
                                    " kcal" + skladniki[i].kcal);
                            }
                            }
                        System.Console.ReadLine();
                        break;
                    }
                case '2':
                    {
                        skladniki[Skladnik.ileSkladnikowNiePustych(skladniki)+1] = new Skladnik();
                        break;
                    } 
                case '3':
                    {
                        for (int i = 0; i < skladniki.Length; i++)
                        {
                            if (skladniki[i] != null)
                                Console.WriteLine(i+". " + skladniki[i].nazwa +" "+ skladniki[i].objetosc + "g B:" +
                                    skladniki[i].bialko + " W:" + skladniki[i].weglowodany +" T:" + skladniki[i].tluszcze +
                                    " kcal" + skladniki[i].kcal);
                        }
                        Console.WriteLine("Który produkt chcesz dodać ?");
                         wybor2 = int.Parse(System.Console.ReadLine());
                        skladnikiNaDanie[Skladnik.ileSkladnikowNiePustych(skladnikiNaDanie) + 1] = skladniki[wybor2];

                        break;
                    }
                case '4':
                    {
                    


                        danie = Skladnik.stworzDanie(skladnikiNaDanie);

                        break;
                    }

                case '5':
                    {
                        a.zjedzDanie(danie);
                        break;

                    }
                case '6':
                    {
                        a.zapotrzebowanieKaloryczne();
                        System.Console.ReadLine();
                        break;
                    }
            }

        }


    }
}