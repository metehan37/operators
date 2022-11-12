namespace operators;
class Program
{
    static void Main(string[] args)
    {
        // Atama ve işlemli atama operatörleri
        Console.WriteLine("Atama ve İşlemli operatörler !!!!!");
        int x = 3;
        int y =3;
        y=y+2;
        Console.WriteLine(y);
        y+=2;
        Console.WriteLine(y);
        y/=1;
        Console.WriteLine(y);
        x *=2;
        Console.WriteLine(x);

        //Mantıksal (||,&&)
        Console.WriteLine("Mantıksal operatörler !!!!!");
        bool isSuccess = true;
        bool isComplated = false;
        if (isSuccess || isComplated)
        {
            Console.WriteLine("veya");
        }
        if (isSuccess && isComplated)
        {
            Console.WriteLine("ve1");
        }
        if (isSuccess && !isComplated)
        {
            Console.WriteLine("ve2");
        }
        //İlişkisel Operatörler
        Console.WriteLine("İlişkisel operatörler !!!!!");
        int a =3;
        int b=4;
        bool sonuc = a<b;
        Console.WriteLine(sonuc);
        sonuc=a>b;
        Console.WriteLine(sonuc);
        sonuc=a>=b;
        Console.WriteLine(sonuc);
        sonuc=a<=b;
        Console.WriteLine(sonuc);
        sonuc= a==b;
        Console.WriteLine(sonuc);
        sonuc= a!=b;
        Console.WriteLine(sonuc);

        //Aritmetik operatörler

        int sayi1=19;
        int sayi2=2;
        int sonuc1=sayi1*sayi2;
        Console.WriteLine(sonuc1);
        sonuc1=sayi1/sayi2;
        Console.WriteLine(sonuc1);
        sonuc1=sayi1+sayi2;
        Console.WriteLine(sonuc1);
        sonuc1=sayi1++;
        Console.WriteLine(sonuc1);
        // % mod
        int sonuc2 =15%3;
        Console.WriteLine(sonuc2);
    }
}
