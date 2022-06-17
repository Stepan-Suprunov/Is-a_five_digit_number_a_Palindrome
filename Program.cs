// Является ли пятизначное число палиндромом.

Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();

char[] ar = num.ToCharArray();

if (ar.Length == 5)
{

    if (ar[0] == ar[4])
    {
        if (ar[1] == ar[3])
        {
            Console.WriteLine("Да");
        }
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Введено не корректное число");
}
