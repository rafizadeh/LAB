using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30012020
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(100,5);

            Console.WriteLine("Welcome to the Car Application");
            Console.WriteLine("*******************************");
            int select = 0;
            string selectedStr;


            do
            {
                Console.WriteLine("1. Sur");
                Console.WriteLine("2. Yanacaq elave et");
                Console.WriteLine("3. Local km");
                Console.WriteLine("4. Global km");
                Console.WriteLine("0. Cixis");

                selectedStr = Console.ReadLine();
                select = Convert.ToInt32(selectedStr);


                switch (select)
                {
                    case 1:
                        Console.WriteLine("*******************************");
                        Console.WriteLine("Surmek istediyiniz km yazin:");
                        string kmStr = Console.ReadLine();
                        double km;

                        while(!double.TryParse(kmStr, out km) || km <= 0)
                        {
                            Console.WriteLine("Duzgun km daxil edin!!");
                            kmStr = Console.ReadLine();
                        }
                        if (car.Drive(km))
                        {
                            Console.WriteLine("Siz mashini {0} km surdunuz, bundan sonra {1} km sure bilersiniz ",km, car.MaxLimit);
                        }
                        else
                        {
                            Console.WriteLine("{0} km sure bilmezsiniz, chunki {1} km gede bilersiniz", km, car.MaxLimit);
                            kmStr = Console.ReadLine();
                        }


                        break;
                    case 2:
                        Console.WriteLine("*******************************");
                        Console.WriteLine("Elave etmek istediyiniz litri yazin:");
                        string litrStr = Console.ReadLine();
                        double litr;

                        while (!double.TryParse(litrStr, out litr) || litr < 0)
                        {
                            Console.WriteLine("Litri duzgun daxil edin!");
                            litrStr = Console.ReadLine();
                        }
                        if (car.AddFuel(litr))
                        {
                            Console.WriteLine("Siz {0} litr yanacaq elave etdiniz, bundan sonra {1} km sure bilersiniz", litr, car.MaxLimit);
                        }
                        else
                        {
                            Console.WriteLine("{0} litr elave ede bilmezsiniz chunki {1} litr kapasite qalib", litr, car.NeededFuel());
                            litrStr = Console.ReadLine();
                        }


                        break;
                    case 3:
                        Console.WriteLine("*******************************");
                        Console.WriteLine("Local km: {0}km ", car.LocalKm);
                        Console.WriteLine("Local km'i 0'lamaq isteyirsiniz mi?(y/n)");
                        string s = Console.ReadLine();

                        if(s.ToLower() != "y" && s.ToLower() != "n")
                        {
                            Console.WriteLine("Adam ol, sechim yalniz y/n ola biler!");
                        }
                        else if(s.ToLower() == "y")
                        {
                            car.ResetLocal();
                            Console.WriteLine("Local km sifirlandi.");
                        }

                        break;
                    case 4:
                        Console.WriteLine("*******************************");
                        Console.WriteLine("Global km: {0}", car.GlobalKm);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("*******************************");
                        Console.WriteLine("Sechiminizi duzgun daxil edin!");
                        break;
                }

            } while (select != 0);

        }
    }
}
