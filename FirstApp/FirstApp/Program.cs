// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World! AGAIN");
Console.WriteLine("Hello, World! AGAIN AND AGAIN");
Console.WriteLine("bruh");

static double GetAverage(int[] tab)
{
    double avg = 0.0;
    foreach (int number in tab)
    {
        avg += number;
    }
    return avg/tab.Length;;
}

int[] tab = { 1,2,3,4};
double avg = GetAverage(tab);
Console.WriteLine(avg);

static int GetMax(int[] tab)
{
    int max = 0;
    foreach (int number in tab)
    {
        max = number > max ? number : max;
    }
    return max;

}
Console.WriteLine(GetMax(tab));