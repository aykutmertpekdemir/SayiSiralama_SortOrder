using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenSayilariSiralamaOperasyonu_SortOrder
{
    class Program
    {
              
            static void Main(string[] args)
            {
                Console.WriteLine("Choose your language: \n Dil seçiniz: \n Türkçe için T, for English press E ");
                char letter = Convert.ToChar(Console.ReadLine());
                if (letter == 'T' || letter == 't')
                {
                    SayiSırala();
                }
                else if (letter == 'E' || letter == 'e')
                {
                    NumberSorting();
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama yaptınız. (Incorrect Dialing)");
                }




            }
            static void SayiSırala()
            {
                Console.Write("Sıralama şeklinizi seçiniz: \n" +
                   "1-)Büyükten Küçüğe Sıralama " +
                   "2-) Küçükten Büyüğe Sıralama:  ");
                byte sıralama = Convert.ToByte(Console.ReadLine());

                Console.Write("Sıralayacağınız sayı adedini giriniz: ");
                int sayiadedi = Convert.ToInt16(Console.ReadLine());
                double[] sayilar = new double[sayiadedi];
                for (int i = 0; i < sayiadedi; i++)
                {
                    Console.Write((i + 1) + ". sayıyı giriniz: ");
                    sayilar[i] = Convert.ToDouble(Console.ReadLine());
                }

                if (sıralama == 1)
                {
                    Array.Sort(sayilar);
                    Array.Reverse(sayilar);
                }
                else
                {
                    Array.Sort(sayilar);
                }
                Console.WriteLine("\n Sayıların istenilen şekilde sıralanmış hali: \n");
                foreach (double sayi in sayilar)
                {
                    Console.WriteLine(sayi);
                }

                Console.ReadKey();
            }
            static void NumberSorting()
            {
                Console.Write("Choose your sort order: \n" +
                   "1-)Descending Order" +
                   "2-)Ascending Order:  ");
                byte sorter = Convert.ToByte(Console.ReadLine());

                Console.Write("Enter the number of numbers you will sort: ");
                int numberofnumbers = Convert.ToInt16(Console.ReadLine());
                double[] numbers = new double[numberofnumbers];
                for (int i = 0; i < numberofnumbers; i++)
                {
                    Console.Write("Enter the " + (i + 1) + ". number: ");
                    numbers[i] = Convert.ToDouble(Console.ReadLine());
                }

                if (sorter == 1)
                {
                    Array.Sort(numbers);
                    Array.Reverse(numbers);
                }
                else
                {
                    Array.Sort(numbers);
                }
                Console.WriteLine("\n Numbers ordered as desired: \n");
                foreach (double number in numbers)
                {
                    Console.WriteLine(number);
                }

                Console.ReadKey();
            }
        
    }
}
