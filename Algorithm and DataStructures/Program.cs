using Algorithm_and_DataStructures;


Console.WriteLine("Merge_Sort");
Console.WriteLine("Type a Statement");
string s = Console.ReadLine();
string[] CheckArr = s.Split(' ');
for (int i = 0; i < CheckArr.Length; i++)
{
    Console.Write(CheckArr[i] + " ");
}

string[] newArray = AlgorithmDataStructures.Merge_Sort(CheckArr, 0, CheckArr.Length - 1);
Console.WriteLine("\nModified One");
for (int i = 0; i < CheckArr.Length; i++)
{
    Console.Write(newArray[i] + " ");
}