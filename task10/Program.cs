Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num > -1000 && num < -99) || (num > 99 && num < 1000))
{
    Console.Write($"Третье значение вашего числа = {num % 10}");
}
else
{
    Console.Write("Ошибка. Введенное число должно быть трехзначным.");
}
