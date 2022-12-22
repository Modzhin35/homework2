Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int ind = 0;
while (num <= -1000 || num >= 1000)
{
    num = num / 10;
    ind++;
}
if (num <= -100 || num >= 100)
{
    Console.Write($"Третье значение вашего числа = {num % 10}.");
}
else
{
    Console.Write($"Ошибка, в числе должно быть не менее 3-х знаков.");
}

