int number = new Random().Next(1, 100);
Console.WriteLine("Я загадала число:) Угадай его:)");
int answer = 0;

while (answer != number)
{
    answer = Convert.ToInt32(Console.ReadLine());
    if (answer > number)
    {
        Console.WriteLine("Число меньше");
    }
    else
    {
        Console.WriteLine("Число больше");

    }
}

Console.WriteLine("А ты угадал!!!:) Молодец!");