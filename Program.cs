begin:

Console.Write("Введите число, обозначающее день недели: ");
int a = Convert.ToInt32(Console.ReadLine());


if (a < 1 || a > 7)
{
    System.Console.WriteLine("такого дня недели не существует");
    goto begin;
}

switch (a)
{
    case 6:
        {
            System.Console.WriteLine("да");
            break;
        }

    case 7:
        {
            System.Console.WriteLine("да");
            break;
        }

    default:
        {
            System.Console.WriteLine("нет");
            break;
        }
}
