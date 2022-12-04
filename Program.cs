/*
int CutNumber(int num)
{
    int ed = num % 10;
    int sot = num / 100;

    int result = sot * 10 + ed;
    return result;
}

int rundNum = new Random().Next(100, 1000);
int newNum = CutNumber(rundNum);

Console.WriteLine($"Новая версия числа {rundNum} это {newNum}");
*/

// Задача: Сучайное число от 10 до 99 которое показывает наибольшую цифру числа.

/*
int MaxNum(int num)

{
    int ed = num % 10;
    int doz = num / 10;
    int max = ed;
    if(max < doz) max = doz;
    
    return max;
}

int rundNum = new Random().Next(10, 100);
int newNum = MaxNum(rundNum);

Console.WriteLine($"Большее число из представленного {rundNum} это {newNum}");
*/

// Задача: Программа принимаетчисло и проверяет кратно ли оно одновременно a и b.

Console.Write("Введите первое число : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  число b: ");
int b = Convert.ToInt32(Console.ReadLine());

void Rund(int num, int a, int b)
{
    if(num % a == 0 && num % b == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Не кратно");
    }
    
}
Rund(num, a, b);