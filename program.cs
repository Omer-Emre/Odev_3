using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace odev_3;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("1. sayıyı girin :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("2. sayıyı girin :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("1. Toplama");
        Console.WriteLine("2. Çıkarma");
        Console.WriteLine("3. Çarpma");
        Console.WriteLine("4. Bölme");
              
        Console.WriteLine("Hangi İşlemi Yapacaksınız (1/2/3/4) :");      
        int secim = Convert.ToInt32(Console.ReadLine());

        int toplama = sayi1 + sayi2;
        int çıkarma = sayi1 - sayi2;
        int çarpma = sayi1 * sayi2;
        int bölme = sayi1 / sayi2;

        if (secim == 1){
           Console.WriteLine($"{sayi1}+{sayi2}={toplama}");
        }
        else if (secim == 2){
           Console.WriteLine($"{sayi1}-{sayi2}={çıkarma}");
        }
        else if (secim == 3){
           Console.WriteLine($"{sayi1}x{sayi2}={çarpma}");
        }
        else if (secim == 4){
           Console.WriteLine($"{sayi1}/{sayi2}={bölme}");          
        }
        else {
            Console.WriteLine("Tanınmayan Karakter");
        }*/
        /*
        Console.WriteLine("1. sayıyı girin :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("2. sayıyı girin :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("1. Toplama");
        Console.WriteLine("2. Çıkarma");
        Console.WriteLine("3. Çarpma");
        Console.WriteLine("4. Bölme");
              
        Console.WriteLine("Hangi İşlemi Yapacaksınız (1/2/3/4) :");      
        int secim = Convert.ToInt32(Console.ReadLine());

        int toplama = sayi1 + sayi2;
        int çıkarma = sayi1 - sayi2;
        int çarpma = sayi1 * sayi2;
        int bölme = sayi1 / sayi2;
    
        switch (secim)
        {
            case 1:
            Console.WriteLine($"{sayi1}+{sayi2}={toplama}");
            break;

            case 2:
            Console.WriteLine($"{sayi1}-{sayi2}={çıkarma}");
            break;

            case 3:
            Console.WriteLine($"{sayi1}x{sayi2}={çarpma}");
            break;

            case 4:
            Console.WriteLine($"{sayi1}/{sayi2}={bölme}"); 
            break;

            default :
            Console.WriteLine("Tanınmayan Karakter");     
            break;     
        }
        */
        /*
        Console.WriteLine("sayı girin :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        if (sayi1 > 0){
           Console.WriteLine("Positive"); 
        }
        if (sayi1 < 0){
           Console.WriteLine("Negativ");
        }
        */
        /*
        Console.WriteLine("sayı girin :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("sayı girin :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("sayı girin :");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        if (sayi1 > sayi2 && sayi1 > sayi3){
        Console.WriteLine($"Girdiğiniz En Büyük Sayı = {sayi1}");
        }
        else if (sayi2 > sayi1 && sayi2 > sayi3){
        Console.WriteLine($"Girdiğiniz En Büyük Sayı = {sayi2}");
        }
        else if (sayi3 > sayi2 && sayi3 > sayi1){
        Console.WriteLine($"Girdiğiniz En Büyük Sayı = {sayi3}");
        }*/
        /*
         while (true){
        Console.WriteLine("sayı girin :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        
        int işlem = sayi1 * 10;

        Console.WriteLine($"{işlem}");

        if (sayi1 == 0){
            break;
        }

        }*/
        /*
        Console.WriteLine("1. sayı girin :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("2. sayı girin :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        
        while(sayi1 <= sayi2){
             Console.WriteLine(sayi1 ++);
        }*/
        /*
        int toplam = 0;
        while (true){
         Console.WriteLine("1. sayı girin :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
         toplam += sayi1;
        if (sayi1 == 0)
        {
         break;
        }
         else {
            Console.WriteLine($"{toplam}");
         }
        }
        Console.WriteLine($"Toplam Sonuç = {toplam}");
         */
         /*
        Console.WriteLine("1. sayı girin :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("2. sayı girin :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());   

        Console.WriteLine("3. sayı girin :");
        int sayi3 = Convert.ToInt32(Console.ReadLine());
    
        Console.WriteLine("4. sayı girin :");
        int sayi4 = Convert.ToInt32(Console.ReadLine());
    
        Console.WriteLine("5. sayı girin :");
        int sayi5 = Convert.ToInt32(Console.ReadLine());    
    
         int toplama = sayi1 + sayi2 + sayi3 + sayi4 + sayi5;

         int ort = (sayi1 + sayi2 + sayi3 + sayi4 + sayi5)/5;
         
         int max = sayi1;
         int min = sayi1;

         if (sayi1 > sayi2 && sayi1 > sayi3 && sayi1 > sayi4 && sayi1 > sayi5)
         {
            max = sayi1;
         }
         else if (sayi2 > sayi1 && sayi2 > sayi3 && sayi2 > sayi4 && sayi2 > sayi5)
         {
            max = sayi2;
         }
         else if (sayi3 > sayi2 && sayi3 > sayi1 && sayi3 > sayi4 && sayi3 > sayi5)
         {
            max = sayi3;
         }
         else if (sayi4 > sayi2 && sayi4 > sayi3 && sayi4 > sayi1 && sayi4 > sayi5)
         {
            max = sayi4;
         }
         else if (sayi5 > sayi2 && sayi5 > sayi3 && sayi5 > sayi4 && sayi5 > sayi1)
         {
            max = sayi5;
         }

         if (sayi1 < sayi2 && sayi1 < sayi3 && sayi1 < sayi4 && sayi1 < sayi5)
         {
            min = sayi1;
         }
         else if (sayi2 < sayi1 && sayi2 < sayi3 && sayi2 < sayi4 && sayi2 < sayi5)
         {
            min = sayi2;
         }
         else if (sayi3 < sayi2 && sayi3 < sayi1 && sayi3 < sayi4 && sayi3 < sayi5)
         {
            min = sayi3;
         }
         else if (sayi4 < sayi2 && sayi4 < sayi3 && sayi4 < sayi1 && sayi4 < sayi5)
         {
            min = sayi4;
         }
         else if (sayi5 < sayi2 && sayi5 < sayi3 && sayi5 < sayi4 && sayi5 < sayi1)
         {
            min = sayi5;
         }   
    
         Console.WriteLine($"Toplam: {toplama}");
         Console.WriteLine($"Ortalama: {ort}");
         Console.WriteLine($"Max: {max}"); 
         Console.WriteLine($"Min: {min}");
        */
        /*
        Console.WriteLine("x girin :");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("y girin :");
        int y = Convert.ToInt32(Console.ReadLine());        
           
        for ( int i = 1;i < y;i++){
        Console.Write($"{x}");}
    */
         /*
         int i = 0;
         while (true)
         {
           if (i<501){
             Console.WriteLine(i);
             i+=15;
           }
          else
          {
            break;
          }
          }
         */
         /*
         int deneme_hakkı =3;
         while (true )
         {
            if (deneme_hakkı == 0){
               Console.WriteLine("hakkınızz bitti :");
               break;
            }
            else
            {
            Console.WriteLine("giriş yapınız : ");
            int giriş = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("şifre giriniz : ");
            int şifre = Convert.ToInt32(Console.ReadLine());

            if (giriş == 12 && şifre == 1234)
            {
               Console.WriteLine("giriş başarılı ");
               break;
            }
            else
            {
               Console.WriteLine("giriş başarısız");
               deneme_hakkı--;
            }
            }
         }
          */     
         /*
         while(true) 
         {
        Console.WriteLine("1. sayı girin :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("2. sayı girin :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());     
        if(sayi1 == 0)
        {
         break;
        }      
       else if(sayi2 == 0)
       {
        Console.WriteLine("0'a bölünmez");
       }      
      else{
      int işlem2 = sayi1 / sayi2;
      Console.WriteLine($"Sonuç: {işlem2}");
      int işlem1 = sayi1 % sayi2;
      Console.WriteLine($"Kalan: {işlem1}");
      
      }
      }
        */ 

      /*
      Console.WriteLine("Başlangıç sayısı (x): ");
      int x = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Bitiş sayısı (y): ");
      int y = Convert.ToInt32(Console.ReadLine());

      int mult = 1;
      while (x <= y)
      {
      int result = x * mult;
      Console.WriteLine($"{x}x{mult} : {result}");
      mult++;
      if (mult == 10)
      {
      x++;
      mult = 1;
      Console.WriteLine();
      }
      }

      while (y <= x)
      {
      int result = y * mult;
      Console.WriteLine($"{y}x{mult} : {result}");
      mult++;
      if (mult == 10)
      {
      y++;
      mult = 1;
      Console.WriteLine();
      }
      }
      */
      /*
      Console.WriteLine("not giriniz :");
      int note = Convert.ToInt32(Console.ReadLine());
        
      switch(note){

         case 10:
         Console.WriteLine("A+");
         break;

         case 9:
         Console.WriteLine("A");
         break;

         case 8:
         Console.WriteLine("B+");
         break;

         case 7:
         Console.WriteLine("B");
         break;

         case 6:
         Console.WriteLine("C");
         break;

         case 5:
         Console.WriteLine("E");
         break;8

         case 4:
         Console.WriteLine("F");
         break;

         case 3:
         Console.WriteLine("F");
         break;

         case 2:
         Console.WriteLine("F");
         break;

         case 1:
         Console.WriteLine("F");
         break;

         case 0:
         Console.WriteLine("F");
         break;

         default:
         Console.WriteLine("Böyle Bir Not Yok");
         break;
      }
      */
      /*
        Console.WriteLine("1. sayı girin :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("2. sayı girin :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        
        while(sayi1 <= sayi2){
             Console.Write( sayi1 ++);      
        }
        */
        /*
        Console.WriteLine("1. sayı girin :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("2. sayı girin :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1;sayi1 <= sayi2;i++)
        {
           Console.Write(sayi1 ++);
        }
        */
        /*
        Console.WriteLine("1. sayı girin :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("2. sayı girin :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        
        do 
        {
            Console.Write( sayi1 ++);

        }while(sayi1 <= sayi2);
          */
         /*
        Console.WriteLine("1. sayı girin :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        int sayac = 0;
        
         if(sayi1 > 0){
            while(sayi1 > 0)
        {
          sayi1 /= 10;
          sayac ++;
        }
         Console.WriteLine($"{sayac} basamaklı");
         }
         
         else if(sayi1 < 0){
            sayi1 *= -1;
            Console.WriteLine("Sayı Negatif");
            while(sayi1 > 0)
        {
          sayi1 /= 10;
          sayac ++;
        }
         Console.WriteLine($"{sayac} basamaklı");
        
        
          }
          */
          /*
          for(char i = 'A';i <= 'Z'; i ++)
          {
            Console.Write(i);
          }
         */
         /*
        Console.WriteLine("sayıyı giriniz :");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi > 0)
        {
         Console.WriteLine($"{sayi}");
        }
        else if (sayi < 0)
        {
         Console.WriteLine($"{sayi}");
        }
         */
         /*
        Console.WriteLine("1. sayı girin :");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("2. sayı girin :");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
       int toplam = 0;
       for(int i = 1;i <= sayi1; i++)
       {
       toplam += sayi2;
       }
         Console.WriteLine(toplam);
      */
      /*
        int kontrol = 0;
        Console.WriteLine("sayıyı giriniz :");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int i = 2;

        if (sayi % i == 0){
        kontrol ++;
        }
         i ++;
        if(kontrol != 0)
        {
         Console.WriteLine("Bu Bir Asal sayi değil");
        }
        else
        {
         Console.WriteLine("bu bir asal sayı");
        }
         */
         /*
         Console.WriteLine("ilk sayıyı girin:");
         int num1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("ikinci sayıyı griin:");
         int num2 = Convert.ToInt32(Console.ReadLine()); 
         while(num1 >= num2)
         {
            Console.Write(num2 + " ");
            num2 ++;
         }
         */
         /*
         Console.WriteLine("ürün fiyatını giriniz:");
         int ürün = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("ne kadar nakit para vereceksiniz:");
         int para = Convert.ToInt32(Console.ReadLine()); 

         double paraüstü = para -ürün ;


       while (true){
         if (paraüstü == 0){
          Console.WriteLine("para üstü yok");
          break;
         }
         else if (ürün > para){
            Console.WriteLine("Baran yetmiyor");
         }
         else if (paraüstü  >= 100){
            paraüstü -= 100 ;
            Console.Write("para üstü" + "100" + "TL");
         }
         else if (paraüstü  >= 50){
         paraüstü -= 50 ;
            Console.Write("para üstü" + "50" + "TL");
         }
         else if (paraüstü  >= 20){
         paraüstü -= 20 ;
         Console.Write("para üstü" + "20" + "TL");
         }
         else if (paraüstü  >= 10){
         paraüstü -= 10 ;
         Console.Write("para üstü" + "10" + "TL");
         }
         else if (paraüstü  >= 5){
         paraüstü -= 5 ;
         Console.Write("para üstü" + "5" + "TL");
         }
         else if (paraüstü  >= 2){
         paraüstü -= 2 ;
         Console.Write("para üstü" + "2" + "TL");
         }
          
         
         }
         */
         /*
         Console.WriteLine("ilk sayıyı girin:");
         int num1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("ikinci sayıyı griin:");
         int num2 = Convert.ToInt32(Console.ReadLine()); 

         
         string sonuc= (num1 > 0) ? " Pozitif":" Negatif";Console.WriteLine(sonuc);

         string sonuc1= (num2 > 0) ? " Pozitif":" Negatif";Console.WriteLine(sonuc1);

         if (sonuc == sonuc1)
         {
           Console.WriteLine("İkiside "+sonuc);
         }
         else{
            Console.WriteLine(sonuc+":"+num1+" "+sonuc1+":"+num2);
         }
         */
         /*
         Console.WriteLine("ilk sayıyı girin:");
         int num1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("ikinci sayıyı griin:");
         int num2 = Convert.ToInt32(Console.ReadLine()); 
         int sayac = 0;
         
         string sonuc= (num1 > 0) ? "Pozitif":"Negatif";Console.WriteLine(sonuc);

         string sonuc1= (num2 > 0) ? "Pozitif":"Negatif";Console.WriteLine(sonuc1);

         if (sonuc == "Pozitif")
         {
            sayac ++;
         }
         else if (sonuc1 == "Pozitif")
         {
            sayac ++;
         }
         */
}
}
