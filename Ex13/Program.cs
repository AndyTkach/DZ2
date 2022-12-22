Console.WriteLine("Введите целое чилсо: ");
string userInput = Console.ReadLine() ?? "";

int number = int.Parse(userInput);
int result = 0;

if (number > 99)
{
    result = (number / 100) % 10;
    Console.WriteLine($"{number} -> {result}");
}
else 
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}

