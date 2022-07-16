Console.Write("Введите цифры, обознащающую день недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());
if (dayWeek == 6 || dayWeek ==7)
{
    Console.WriteLine("{0} -> да это выходной", dayWeek);
}
else if (dayWeek >= 1 && dayWeek <=5)
{
    Console.WriteLine("{0} -> Это не выходной", dayWeek);
}
else
{
    Console.WriteLine("{0} -> дня недели с такой цифрой нет", dayWeek);
}
