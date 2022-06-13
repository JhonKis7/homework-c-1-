//Задача1

/*Console.Write("input num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine(num2);
}
*/
//Задача2
/*
Console.Write("input num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input num3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max); */

//Задача3

/*Console.Write("input num: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
Console.WriteLine("Del");
}
else
Console.WriteLine("NoDel");*/

//Задача4

Console.Write("input num: ");
int num = Convert.ToInt32(Console.ReadLine());
int min = 2;
while (min <= num)
{
    Console.Write(min +" ");
    min = min + 2;
}