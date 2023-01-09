// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage");

Random random = new Random();
int result = random.Next(0, 2);
if (result == 1)
{
    Console.WriteLine("Employee is Present");
}
else
{
    Console.WriteLine("Employee is absent");
}