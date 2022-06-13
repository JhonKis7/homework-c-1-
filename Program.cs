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
Console.WriteLine(max);
