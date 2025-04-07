//Exercise 1
//Try to simplify the following Code by creating a Function "RollDice".
//This Function should have a Parameter which specifies how many sides the dice has

using System;

RollDice(7);

void RollDice(int numSides)
{
    Random rng = new Random();
    int diceRoll = rng.Next(1, numSides+1);
    Console.WriteLine("You rolled a" + numSides + "-sided dice: " + diceRoll);
}

//Exercise 2
//Write a Function which can print string-arrays to the console.
//Use it to print both arrays.
string[] childrenList = new string[] { "Bob Jr.", "Lisa", "Minerva" };
string[] grownUpsList = new string[] { "Bob", "Annie", "Mary" };

PrintStrings(childrenList);
void PrintStrings(string[] strings)
{
    //for (int i =0; i< strings.Length; i++)
    //{
    //    Console.WriteLine(strings[i]);
    //}
    foreach(string name in strings)
    {
        Console.WriteLine(name);
    }
}

//Exercise 3
//Write a Greet-Function with two parameters: name, age
//The Function should greet the user in different ways based on their age:
//
//if age < 18: "Hey Timmy, how are you?"
//if age >= 18: "Hello Robert, how are you?"
//
//Bonus: Add an optional parameter for the Title.
//i.e.: Hello Dr. Robert, how are you?
Greet("Robter", 15);
Greet("Marc", 21, "Dr.");
void Greet(string name, int age, string title = "")
{
    string space = "";
    if (title != "")
    {
        space = " ";
    }

    if (age < 18)
    {
        Console.WriteLine("Hey " + title + space + name + ", how are you");
    }
    else
    {
        Console.WriteLine("Hello " + title + space + name + ", how are you");
    }
}

