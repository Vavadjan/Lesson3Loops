using System.Runtime.CompilerServices;

namespace Lesson3Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
              while (условие при соблюдении которого цикл будет работать)
            {
            //действие (инструкции), которые будут выполняться при каждой итерации работы цикла       
            }

            

            int x = 0; //1. Управляющая циклом переменная

            Console.WriteLine("number\tsquare\tcube");
            while (x <= 10) // 2. Условие при котором цикл будет продолжать свою работу
            {
                Console.WriteLine(x + "\t" + (x*x) + "\t" + (x * x * x)); //Действия
                x++; //3. Правило изменения управляющей переменной
            }

            while (true) //пример бесконечного цикла
            {
                Console.WriteLine(x);
                break; //ключевое слово для остановки цикла
            }

            int i = 0;

            while (true)
            {
                Console.WriteLine(i);
                if (i == 100) 
                    break;

                i++;
            }

            Console.Clear();

            int f = 1;

            while (f <=10)
            {
                Console.Write(f + ", "); //Метод Console.Write выводит данные без переноса строки вниз.
                f++;
            }



            Console.Clear();

            int q = 100;

            while (q >= 0)
            {
                Console.Write(q + ", "); //Метод Console.Write выводит данные без переноса строки вниз.
                q--;
            }



            Console.Clear();

            int w = 7;

            while (w <= 77)
            {
                Console.Write(w + ", "); //Метод Console.Write выводит данные без переноса строки вниз.
                w = w + 7;
            }


            Console.Clear();

            int e = 20;

            while (e >= -20)
            {
                Console.Write(e + ", "); //Метод Console.Write выводит данные без переноса строки вниз.
                e = e - 5;
            }


            Console.Clear();

            f = 1;
            decimal sum = 0; //Накопительная переменная

            while (f <= 10)
            {
                Console.WriteLine("Введите вашу зарплату: ");
                decimal d = Convert.ToDecimal(Console.ReadLine());
                if (d == 0)
                {
                    break;
                }
                sum = sum + d;
                f++;
            }
            Console.WriteLine(sum);

            Console.Clear();


            x = 10;

            while (x < 10)//Сначала произойдёт проверка в результате которой цикл определит срабатывать ли ему.
            {
                Console.WriteLine(x);
                x++;
            }

            do //Независимо от условия, действия в цикле точно, хотя бы один раз, выполняться.
            {
                Console.WriteLine(x);
                x++;
            } while (x < 10);

            Console.Clear();


            //Спросить у пользователя его возраст. Если возраст > 18 или < 99 - завершить работу цикла. Иначе продолжать спрашивать возраст.             
            //Спрашивать возраст пользователя до тех пор пока он не введёт значение > 18 или < 99.

            int a =22;
            do
            {
                Console.WriteLine("Enter your age: ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a < 18 || a > 99);


            */


            


            //Записать циклы while и do while, выводящие на экран следующие последовательности
            //a. 2 5 8 11 14
            //b. 99 88 77 66 55 44 33 22 11 0


            int qq = 2;            

            while (qq <= 14)
            {
                Console.Write(qq + " ");
                qq = qq + 3;
            }


            int qqq = 99;

            Console.Write("\n");

            while (qqq >= 0) 
            {                
                Console.Write(qqq + " ");
                qqq = qqq - 11;
            }



            int ww = 2;

            Console.WriteLine("\n");

            do
            {
                Console.Write(ww + " ");
                ww = ww + 3;
            }

            while (ww <= 14);


            int www = 99;

            Console.Write("\n");

            do
            {
                Console.Write(www + " ");
                www = www - 11;
            }

            while (www >= 0);


        }
    }
}