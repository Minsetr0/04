Random rand = new Random();
int maxValueInRand = 101;
int number = rand.Next(0, maxValueInRand);
int sum = 0;
int multiplicityCheck1 = 5;
int multiplicityCheck2 = 3;

for (int i = 1; i <= number; i++)
{
    int divisionIntoFive = i % multiplicityCheck1;
    int divisionIntoThree = i % multiplicityCheck2;

    if (divisionIntoFive == 0 || divisionIntoThree == 0)
    {
        Console.WriteLine(i);
        sum += i;
    }
}

Console.WriteLine("Сумма всех чисел, содержащихся в " + number + " и кратных '3' и '5' - " + sum + ".");