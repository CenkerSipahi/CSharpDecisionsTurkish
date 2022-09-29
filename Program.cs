using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If__Else__ElseIf_ve_Ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if(){} : eğer anlamına gelir, parantez içine durum yazılır, köşeli parantez içine ise o durumda yapılacaklar.
            // else if(){} : yukarıdaki ile aynı şey sadece birden fazla durum olduğunda kullanılır.
            // else{} : yazdığınız durumların hiç biri ile eşleşmediğinde burayı kullanır.
            // switch(degişken){} : değişken yani veri burada parantez içine yazılır
            // case : switchin içinde kullanılır olanak anlamına gelir.
            // default : eğer veriniz case'lerden hiçbirine uyuşmazsa burası kullanılır, else ile aynı mantık.
            // break : case ve default'un bittiğini göstermek için işlemlerden sonra sona konur.

            Console.Write("Adınızı Yazınız : ");
            string name = Console.ReadLine();
            Console.Write("Soyadınızı Yazınız : ");
            string surname = Console.ReadLine();
            int time = DateTime.Now.Hour; // Burada programın çalıştırıldığı saati alıyor.

            if(time >= 6 && time <= 12) // Saat sabah 6 ile öğlen 12 arası ise aşağıdakini yazar.
            {
                Console.WriteLine("Günaydın, {0} {1}", name, surname);
                    Console.Write("1 ile 5 dahil aralığında bir sayı giriniz : ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    switch (num) // içeriye kontrol etmek istediğiniz değişkeni yazıyoruz.
                    {
                        case 1: // num değişkeni 1'e eşit ise aşağıdakini yazar.
                            Console.WriteLine("Girdiğiniz Sayı 1!");
                            break;

                        case 2: // num değişkeni 2'ye eşit ise aşağıdakini yazar.
                            Console.WriteLine("Girdiğiniz Sayı 2!");
                            break;

                        case 3: // num değişkeni 3'e eşit ise aşağıdakini yazar.
                            Console.WriteLine("Girdiğiniz Sayı 3!");
                            break;

                        case 4: // num değişkeni 4'e eşit ise aşağıdakini yazar.
                            Console.WriteLine("Girdiğiniz Sayı 4!");
                            break;

                        case 5: // num değişkeni 5'e eşit ise aşağıdakini yazar.
                            Console.WriteLine("Girdiğiniz Sayı 2!");
                            break;

                        default:// num değişkeni yukarıdaki case'lerden hiçbirine eşit değilse aşağıdakini yazar.
                            Console.WriteLine("Verilen aralıkta bir sayı girmediniz programı yeniden başlatınız.");
                            break;
                    }

                    switch (num)
                    {
                        case 1: // Bu şekilde kullanarakta birçok durumu tek bir sonuca birleştirebiliriz.
                        case 3:
                        case 5:
                            Console.WriteLine("Girdiğiniz sayı tek.");
                            break;

                        case 2:
                        case 4:
                            Console.WriteLine("Girdiğiniz sayı çift.");
                            break;
                    }
            }
            else if (time >= 12 && time <= 18)      // Saat öğlen 12 ile akşam 6 arası ise aşağıdakini yazar.
            {
                Console.WriteLine("İyi Günler, {0} {1}", name, surname);
                    Console.Write("1 ile 5 dahil aralığında bir sayı giriniz : ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    switch (num) // içeriye kontrol etmek istediğiniz değişkeni yazıyoruz.
                    {
                        case 1: // num değişkeni 1'e eşit ise aşağıdakini yazar.
                            Console.WriteLine("Girdiğiniz Sayı 1!");
                            break;

                        case 2: // num değişkeni 2'ye eşit ise aşağıdakini yazar.
                            Console.WriteLine("Girdiğiniz Sayı 2!");
                            break;

                        case 3: // num değişkeni 3'e eşit ise aşağıdakini yazar.
                            Console.WriteLine("Girdiğiniz Sayı 3!");
                            break;

                        case 4: // num değişkeni 4'e eşit ise aşağıdakini yazar.
                            Console.WriteLine("Girdiğiniz Sayı 4!");
                            break;

                        case 5: // num değişkeni 5'e eşit ise aşağıdakini yazar.
                            Console.WriteLine("Girdiğiniz Sayı 2!");
                            break;

                        default:// num değişkeni yukarıdaki case'lerden hiçbirine eşit değilse aşağıdakini yazar.
                            Console.WriteLine("Verilen aralıkta bir sayı girmediniz programı yeniden başlatınız.");
                            break;
                    }

                    switch(num)
                    {
                        case 1: // Bu şekilde kullanarakta birçok durumu tek bir sonuca birleştirebiliriz.
                        case 3:
                        case 5:
                        Console.WriteLine("Girdiğiniz sayı tek.");
                        break;

                        case 2:
                        case 4:
                        Console.WriteLine("Girdiğiniz sayı çift.");
                        break;
                    }
            }
            else // Yukarıdaki değerler sağlanmadığında burası kullanılır.
            {
                Console.WriteLine("İyi Akşamlar, {0} {1}", name, surname);
                    Console.Write("1 ile 5 dahil aralığında bir sayı giriniz : ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    switch (num) // içeriye kontrol etmek istediğiniz değişkeni yazıyoruz.
                    {
                        case 1: // num değişkeni 1'e eşit ise aşağıdakini yazar.
                            Console.WriteLine("Girdiğiniz Sayı 1!");
                            break;

                        case 2: // num değişkeni 2'ye eşit ise aşağıdakini yazar.
                            Console.WriteLine("Girdiğiniz Sayı 2!");
                            break;

                        case 3: // num değişkeni 3'e eşit ise aşağıdakini yazar.
                            Console.WriteLine("Girdiğiniz Sayı 3!");
                            break;

                        case 4: // num değişkeni 4'e eşit ise aşağıdakini yazar.
                            Console.WriteLine("Girdiğiniz Sayı 4!");
                            break;

                        case 5: // num değişkeni 5'e eşit ise aşağıdakini yazar.
                            Console.WriteLine("Girdiğiniz Sayı 2!");
                            break;

                        default:// num değişkeni yukarıdaki case'lerden hiçbirine eşit değilse aşağıdakini yazar.
                            Console.WriteLine("Verilen aralıkta bir sayı girmediniz programı yeniden başlatınız.");
                            break;
                    }

                    switch (num)
                    {
                        case 1: // Bu şekilde kullanarakta birçok durumu tek bir sonuca birleştirebiliriz.
                        case 3:
                        case 5:
                            Console.WriteLine("Girdiğiniz sayı tek.");
                            break;

                        case 2:
                        case 4:
                            Console.WriteLine("Girdiğiniz sayı çift.");
                            break;
                    }
            }
                
        }
    }
}
