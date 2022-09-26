//Задача 4


Console.WriteLine("Введите число N:");
string n = Console.ReadLine();
int N = Convert.ToInt32(n);
string Elka = "*";
for (int i = 0; i < N; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.SetCursorPosition(Console.WindowWidth / 2 - j, Console.CursorTop);
        Console.WriteLine(Elka);
        Elka += "**";
    }
    Elka = "*";
}