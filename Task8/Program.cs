/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
 */
 Console.WriteLine("Введите целое положительное число: ");
int numberA = int.Parse(Console.ReadLine());
if( numberA > 0)
{
for (int i = 2; i <= numberA; i= i+2)
{
    Console.Write( i + " ");
}
}
else
{
    Console.Write("Должно быть целое положительное число");
}
