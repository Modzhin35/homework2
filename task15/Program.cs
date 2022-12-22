Console.Write("Введите любое число и узнайте, выходной ли это день: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) num = num * -1; //Если введено отрицательное число, меняем знак
int resNum = num % 7;
if (resNum == 0)
{ //для того, чтобы значение resNum в выводе не выдавало "0", когда выпаадет воскресенье;
    resNum = 7;
}
switch (resNum)
{
    case 6:
    case 7:
        Console.Write($"{num} день это {resNum} день недели - выходной");
        break;
    default:
        Console.Write($"{num} день это {resNum} день недели - рабочий");
        break;
}
