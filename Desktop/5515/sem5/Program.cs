System.Console.WriteLine("Enter number ");
string str1 = Console.ReadLine();
int num = Convert.ToInt32(str1);
if (num>99 & num<1000)
{
    int num2=num%10;
    Console.WriteLine (num2);
}
else Console.WriteLine ("Ошибка");
