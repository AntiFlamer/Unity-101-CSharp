

/*switch (ay)
{
    case 1:
        Console.WriteLine("Ocak");
        break;
    case 2:
        Console.WriteLine("Subat");
        break;
    case 3:
        Console.WriteLine("Mart");
        break;
    case 4:
        Console.WriteLine("Nisan");
        break;
    case 5:
        Console.WriteLine("Mayis");
        break;
    case 6:
        Console.WriteLine("Haziran");
        break;
    case 7:
        Console.WriteLine("Temmuz");
        break;
    case 8:
        Console.WriteLine("Agustos");
        break;
    case 9:
        Console.WriteLine("Eylul");
        break;
    default: Console.WriteLine("Gecersiz ay.");
        break;



}*/

Console.WriteLine("Ay giriniz (rakam ile): ");

int ay = Convert.ToInt32(Console.ReadLine());

string mevsim = null;
if (0 < ay && ay < 13)

{

    if (ay == 12 || ay == 1 || ay == 2)
    {
        mevsim = "Kis";
    }
    else if (ay == 3 || ay == 4 || ay == 5)
    {
        mevsim = "Ilkbahar";
    }
    else if (ay == 6 || ay == 7 || ay == 8)
    {
        mevsim = "Yaz";
    }
    else if (ay == 9 || ay == 10 || ay == 11)
    {
        mevsim = "Sonbahar";
    }
    Console.WriteLine($"{mevsim} mevsimindesiniz.");
}
else
    Console.WriteLine("Gecersiz bir ay girdiniz.");