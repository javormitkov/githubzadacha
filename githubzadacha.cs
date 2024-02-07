Console.WriteLine("vuvedete vashiq budjet:");
double budget = double.Parse(Console.ReadLine());
Console.WriteLine("vuvedete dali bileta e VIP ili Normal:");
string category = Console.ReadLine();
Console.WriteLine("vuvedete broi hora:");
double people = double.Parse(Console.ReadLine());
double transport = 0;
if (people > 0 && people <=4)
{
    transport = 0.75 * budget;
}
else if (people > 4 && people <= 9)
{
    transport = 0.60 * budget;
}
else if (people > 9 && people <= 24)
{
    transport = 0.50 * budget;
}
else if (people > 24 && people <= 49)
{
    transport = 0.40 * budget;
}
else if (people >= 50)
{
    transport = 0.25 * budget;
}
double costAll = 0;
if (category == "VIP")
{
    costAll = 499.99 + transport;
}
else if (category == "Normal")
{
    costAll = 249.99 + transport;
}
if (budget >= costAll)
{
    Console.WriteLine($"Yes! You have {Math.Round((budget - costAll), 2)} leva left.");
}
else if (budget < costAll)
{
    Console.WriteLine($"Not enough money! You need {Math.Round((costAll - budget), 2)} leva.");
}