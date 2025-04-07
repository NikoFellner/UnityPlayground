// See https://aka.ms/new-console-template for more information
#region Exercise 1
float multResult = MultiplyByTwo(1.2f);
float squareResult = SquareFunction(1.2f);
bool inRangeResult = IsNumInRange(4);

Console.WriteLine("multiplication with two result: " + multResult);
Console.WriteLine("square result: " + squareResult);
Console.WriteLine("is num in range: " + inRangeResult);
float MultiplyByTwo(float inputNum)
{
    return inputNum * 2;
}

float SquareFunction(float inputNum)
{
    return inputNum *inputNum;
}

bool IsNumInRange(int inputNum, int minVal = 1, int maxVal = 50)
{
    return inputNum>=minVal && inputNum<=maxVal;
}
#endregion

#region Exercise 2
//int guessCount = GuessingGame();
//Console.WriteLine("You needed " +  guessCount + " for the correct number");
int GuessingGame()
{
    Console.WriteLine("Guess the number I'm thinking of (1 to 10)");
    Random rng = new Random();

    int correctNum = rng.Next(1, 11);
    int guessCount = 1;
    int guessVal;

    while (true)
    {
        guessVal = Convert.ToInt32(Console.ReadLine());


        if (guessVal < correctNum)
        {
            Console.WriteLine("Too low");
        }
        else if (guessVal > correctNum)
        {
            Console.WriteLine("Too high");
        }
        else
        {
            Console.WriteLine("Your answer was correct");
            return guessCount;
        }
        guessCount++;
    }
}
#endregion

#region Exercise 3

int[] myIntArray = new int[10];
Random rng = new Random();

for (int i = 0; i < myIntArray.Length; i++)
{
    myIntArray[i] = rng.Next(1,101);
    Console.WriteLine(myIntArray[i]);
}

int sum = SumOfAnArray(myIntArray);
Console.WriteLine("The Sum is: " + sum);
int SumOfAnArray(int[] myIntArray)
{
    int result = 0;
    for (int i = 0;i < myIntArray.Length;i++)
    {
        result += myIntArray[i];
    }
    return result;
}

int highestVal = FindHighestValueOfArray(myIntArray);
Console.WriteLine("The Highest Value is: " +  highestVal);
int FindHighestValueOfArray(int[] myIntArray)
{
    highestVal = myIntArray[0];
    for (int i = 1;i < myIntArray.Length;i++)
    {
        if (myIntArray[i] > highestVal) 
        { 
            highestVal = myIntArray[i];
        }
    }
    return highestVal;
}

#endregion