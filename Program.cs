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