System.Console.WriteLine("Enter number: ");
string str1 = Console.ReadLine();
System.Console.WriteLine("Enter number2: ");
string str2 = Console.ReadLine();
int num = Convert.ToInt32(str1);
int num2 = Convert.ToInt32(str2);
if (num2 * num2 == num)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}