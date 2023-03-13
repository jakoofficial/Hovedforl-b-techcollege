//Selection, Sequence, Iteration
string[] selections = new string[]
{"One", "two", "Three", "Four", "five", "six", "seven", "eight", "Nine", "ten"};

do
{
    Console.Clear();
    PrintArr(selections);

    Console.WriteLine("Write a number using letters");
    Console.WriteLine(Selection(Console.ReadLine(), selections));

} while (Console.ReadKey().Key != ConsoleKey.Escape);

static void PrintArr(string[] arr)
{
    string res = "";
    foreach (string s in arr) res += s + " ";

    Console.WriteLine(res);
}

static string Selection(string input, string[] selections)
{
    string selected = "";

    foreach (string s in selections)
    {
        if (s.ToUpper().Contains(input))
        {
            selected = "Your selected answer is: " + s;
            return selected;
        }
    }
    return "Nothing like that in the array";
}