using System;

namespace hellorussia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 1000; i++)
            //    Console.WriteLine($"Цикл выполнен {i} раз");
            //foreach (var item in "ананас")
            //    if(item == 'а')
            //    Console.WriteLine("н");
            //    else
            //    {
            //    Console.WriteLine(item);
            //    }



            //int a = 0;
            //while(a<= 100)
            //{
            //    Console.WriteLine(a);
            //        a++;
            //}



            //int a = 1000;
            //while(a >= 0)
            //{
            //    int result = a - 7;
            //    Console.WriteLine($"{a}-7 = {result}");
            //    a = a - 7;
            //}


            string lang = Console.ReadLine();
            switch (lang)
            {
                case "Z":
                    Console.WriteLine("V");
                    break;
                case "V":
                    Console.WriteLine("Z");
                    break;
                case "ru":
                    Console.WriteLine("ы");
                    break;
                case "ы":
                    Console.WriteLine("zzz");
                    break;

                default:
                    Console.WriteLine("ЗЕТ");
                    break;
            }












        }

    }
}
