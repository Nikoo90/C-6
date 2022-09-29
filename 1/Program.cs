
void positiveNumbers()
{
    string x = "";
    int count = 0;
    Console.WriteLine("Чтобы завершить программу нажмите 'Enter'");
    while (true)
    {
        try
        {
            Console.WriteLine("Ведите число:");
            x = Console.ReadLine();
            if (x == "")
            {
                break;
            }
            int num = Convert.ToInt32(x);
            if (num > 0)
            {
                count++;
            }
        }
        catch
        {
            Console.WriteLine($"{x} - это не число!");
            continue;
        }
    }

    Console.WriteLine($"Положителных чисел: {count}");

}

positiveNumbers();

//Рекурсия
int positiveNumbers2()
{
    int count = 0;
    Console.Write("Ведите число: ");
    string x = Console.ReadLine();
    if (x == "")
    {
        return count;
    }
    else
    {
        if (Convert.ToInt32(x) > 0) count++;
        return positiveNumbers2() + count;
    }
}
Console.WriteLine($" positive numbers - {positiveNumbers2()}");