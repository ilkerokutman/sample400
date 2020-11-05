using System;

namespace sample400
{
    class Program
    {
        static void Main(string[] args)
        {
            // 100 ile 400 arasindaki sayilardan tum rakamlari cift olanlari
            // ve bunlarin sayisini bulan bir program yaziniz

            int qty = 0; // kac sayi bu kosulu sagliyor
            int startingNumber = 100; // kactan basliyor
            int endingNumber = 400; // kacta bitiyor

            Console.WriteLine($"{startingNumber} ile {endingNumber} arasindaki sayilardan tum rakamlari cift olan sayilar: ");

            for (int i = startingNumber; i <=endingNumber; i++)
            {
                if (i % 2 == 0)
                {
                    // sayi ikiye bolunebiliyor
                    
                    int digit10 = i / 10; // onlar basamagi bulunuyor

                    if (digit10 % 2 == 0)
                    {
                        // onlar basamagi ikiye bolunebiliyor
                        int digit100 = i / 100; // yuzler basamagi bulunuyor

                        if (digit100 % 2 == 0)
                        {
                            // yuzler basamagi ikiye bolunebiliyor
                            Console.WriteLine(i);
                            qty++;
                        }
                    }
                }
            }
            Console.WriteLine($"Toplam sayi aded: {qty}");
        }
    }
}
