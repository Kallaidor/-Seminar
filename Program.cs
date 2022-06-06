Console.WriteLine("введите число 1");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);

Console.WriteLine("введите число 2");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);

int square = number1 * number1;

if (square == number2)
{
Console.WriteLine("ДА");
}

else 
{
Console.WriteLine("Нет");
}



