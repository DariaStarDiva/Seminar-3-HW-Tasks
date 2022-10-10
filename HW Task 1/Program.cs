// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите пятизначное число ");
int n = Convert.ToInt32(Console.ReadLine());
while ( n<10000 || n > 99999)
{
Console.Write("Введите пятизначное число ");
n = Convert.ToInt32(Console.ReadLine());
}
int n4 = (n%100-n/1000);

if ( n4  < 0 )
 n4 = n4 *(-1);
if ( n4 == 9)
Console.Write("Да, полиандром");
else
Console.Write("НЕТ!");


