Random rand = new Random();
int number = rand.Next(0, 101);
for (float i = 0.0f; i <= number; i++)
{
    float divisionIntoFive = i % 5;
    float divisionIntoThree = i % 3;

    if (divisionIntoFive == 0)
    {
        Console.WriteLine(i);
    }
    else if (divisionIntoThree == 0)
    {
        Console.WriteLine(i);
    }
}   
