Console.WriteLine("Ведiть кiлькiсть клiєнтiв");
int n = int.Parse(Console.ReadLine());
long factorial = 1;
long CalculateAmountOfRouts(int n)
{
    factorial *= n;
    n--;
    if (n > 0)
    {
        CalculateAmountOfRouts(n);
    }
    return factorial;
}
Console.WriteLine($"Iснує {CalculateAmountOfRouts(n)} варiантiв маршрутiв");