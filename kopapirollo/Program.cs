int a;
int b = 0;
Console.Write("Első játékos száma 0 és 2 között (0=kő, 1=papír 2=ólló): ");
a = Convert.ToInt32(Console.ReadLine());
if (a < 0 || a > 2)
{
    do
    {
        Console.Write("A bevitt szám nagyobb mint 2 vagy kisebb mint 0 adjon meg új számot: ");
        a = Convert.ToInt32(Console.ReadLine());

    } while (a < 0 || a > 2);
}
Console.Write("Második játékos száma 0 és 2 között (0=kő, 1=papír 2=ólló): ");
b = Convert.ToInt32(Console.ReadLine());

if (b < 0 || b > 2)
{
    do
    {
        Console.Write("A bevitt szám nagyobb mint 2 vagy kisebb mint 0 adjon meg új számot: ");
        b = Convert.ToInt32(Console.ReadLine());

    } while (b < 0 || b > 2);
}
if (a == 0 && b == 0 || a == 1 && b == 1 || a == 2 && b == 2)
{
    Console.WriteLine("Eredmény kódolva (0-döntetlen, 1-első nyert, 2-második nyert): 0");
}
if (a == 0 && b == 2 || a == 1 && b == 0 || a == 2 && b == 1)
{
    Console.WriteLine("Eredmény kódolva (0-döntetlen, 1-első nyert, 2-második nyert): 1");

}
if (a == 2 && b == 0 || a == 0 && b == 1 || a == 1 && b == 2)
{
    Console.WriteLine("Eredmény kódolva (0-döntetlen, 1-első nyert, 2-második nyert): 2");

}