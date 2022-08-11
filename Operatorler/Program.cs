using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y /= 1; 
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            //Mantıksal operatörler
            // || && !

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }

            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great!");
            }

            if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }

            // İlişkisiel Operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc= a<=b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            sonuc = a!=b;
            Console.WriteLine(sonuc);

            // Aritmetik Operatörler
            // /, *, +, -

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);

            int sonuc2 = sayi1 + sayi2;
            Console.WriteLine(sonuc2);

            int sonuc3 = sayi1 * sayi2;
            Console.WriteLine(sonuc3);

            int sonuc4 = sayi1 - sayi2;
            Console.WriteLine(sonuc4);

            int sonuc5 = sayi1++;
            Console.WriteLine(sonuc5);


            // % : Mod Alma

            int sonuc6 = 20%3;
            Console.WriteLine(sonuc6);
        }
    }
}
