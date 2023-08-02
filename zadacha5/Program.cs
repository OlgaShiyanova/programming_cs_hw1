// Задача 6: Напишите программу, 
// которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Введите число  ");
int number1 = Convert.ToInt32(Console.ReadLine());
int half = number1/2;
if (number1 == 2 * half) 
{
    Console.Write("да");
}
else
{
   Console.Write("нет");
}
 