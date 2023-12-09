System.Console.WriteLine("Enter number ");
string str1 = Console.ReadLine();
int num = Convert.ToInt32(str1);
int numStart = num * -1;
while (numStart <= num)
{
    Console.WriteLine(numStart);
    ++numStart;
}