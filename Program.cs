int number = ReadLine();
int sum = Sum(number);
Console.WriteLine(sum);

int Sum(int a)
{
int sum = 0;
for (int i = 0; i <= a; i++)
{
sum += i;
}
return sum;
}

int ReadLine()
{
Console.WriteLine("Введите число");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
return number;
}
