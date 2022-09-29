
void pointOfIntersection()
{
    double b1 = 0, b2 = 0, k1 = 0, k2 = 0;
    for (int i = 1; i <= 4; i++)
    {
        switch (i)
        {
            case 1:
                Console.WriteLine();
                Console.Write("Ведите b1: ");
                b1 = Convert.ToDouble(Console.ReadLine());

                break;
            case 2:
                Console.Write("Ведите k1: ");
                k1 = Convert.ToDouble(Console.ReadLine());

                break;
            case 3:
                Console.Write("Ведите b2: ");
                b2 = Convert.ToDouble(Console.ReadLine());
                break;
            case 4:
                Console.Write("Ведите k2: ");
                k2 = Convert.ToDouble(Console.ReadLine());
                break;
        }

    }

    double x = (b1 - b2) * -1 / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Точка пересечения ({x};{y})");

}

// y = k1 * x + b1  5x+2
// y = k2 * x + b2  9x+4  4x=-222

pointOfIntersection();
// foreach (double el in arr)
// {
//     Console.WriteLine(el);
// }