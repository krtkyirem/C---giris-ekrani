using System;

namespace kullanici.giris
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime born = DateTime.Now;
            Console.WriteLine(born);
            Console.WriteLine("Hoşgeldiniz");

            try
            {
                Console.WriteLine("Yaşınız:");
                byte age = byte.Parse(Console.ReadLine());

                if (age >= 18)
                {
                    Console.WriteLine("Adınız:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Soyadınız");
                    string lastname = Console.ReadLine();

                    if (name.ToLower() == "irem")
                    {
                        if (lastname.ToLower() != "kurt")
                        {
                            Console.WriteLine("Giriş Başarılı  :) ");
                            Console.WriteLine($" {name}  {lastname} ");
                        }
                        else if (name.ToLower() != "irem" && lastname.ToLower() != "kurt")
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Giriş başarısız ");
                        }

                    }
                   
                }
                else if (age < 18)
                {
                    Console.WriteLine(" Yaşınız 18 den küçük olduğu için giriş yapamazsınız");

                }
                else
                {
                    Console.WriteLine("Hatalı Giriş");
                }
            }

            catch (FormatException)
            {

                Console.WriteLine("Bir sayı giriniz");
                Console.ReadLine();
            }
            catch (OverflowException over)
            {
                Console.WriteLine("Sayı giriniz:");
                Console.WriteLine(over.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Yönetici ile irtibata geçiniz");
                Console.WriteLine(ex.Message);

            }
            Console.ReadLine();
        }
    }
}
