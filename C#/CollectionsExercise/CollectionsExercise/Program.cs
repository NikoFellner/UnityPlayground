// See https://aka.ms/new-console-template for more information
#region Exercise 1
int[] myArray = new int[20];
Random rng = new Random();

for (int i = 0; myArray.Length > i; i++) 
{
    myArray[i] = rng.Next(1, 101);
    Console.WriteLine("This is my " + i + " Value: " + myArray[i]);
}

List<int> list = new List<int>();

for (int j = 0; j < 20; j++)
{
    list.Add(rng.Next(1,101));
    Console.WriteLine("This is my " + j + " Value: " + list[j]);
}
#endregion

#region Exercise 2

List<string> list2 = new List<string>();

while(true)
{
    Console.WriteLine("Please enter any text you want, if you write stop it will end!");
    list2.Add(Console.ReadLine());
    if (list2.Contains("stop"))
    {
        list2.RemoveAt(list2.Count - 1);
        list2.Reverse();
        for (int l=0; l < list2.Count; l++)
        {
            Console.WriteLine(list2[l]);
        }
        break;
        
    }
}
#endregion
