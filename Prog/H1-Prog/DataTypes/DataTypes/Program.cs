bool on = true;
string textForArray = """
                    How many array spaces?
                    """;

do
{
    Console.Clear();

    Console.WriteLine("""
    Pick:
    *------Types-------*
    Byte
    Int
    Char
    Float
    Double
    *------------------*
    End
    """);

    Pick(Console.ReadLine());

} while (on);

Console.WriteLine("Goodbye! o7");
Console.ReadKey();


void Pick(string input)
{
    Console.Clear();
    int bytes = 0;
    string t = "";
    int inp = 0;
    switch (input.ToLower())
    {
        case "byte":
            bytes = sizeof(byte);
            t = "Byte";
            GetValues(bytes, t);

            if (AskForArr())
            {
                Console.Clear();
                Console.WriteLine(textForArray);
                Gen<byte> gen = new Gen<byte>();

                Int32.TryParse(Console.ReadLine(), out inp);
                bytes = gen.AsArr(inp);

                GetValues(bytes, t);
            }
            break;
        case "int":
            bytes = sizeof(int);
            t = "Integer";
            GetValues(bytes, t);

            if (AskForArr())
            {
                Console.Clear();
                Console.WriteLine(textForArray);
                Gen<int> gen = new Gen<int>();

                Int32.TryParse(Console.ReadLine(), out inp);
                bytes = gen.AsArr(inp);

                GetValues(bytes, t);
            }
            break;
        case "char":
            bytes = sizeof(char);
            t = "Char";

            GetValues(bytes, t);
            if (AskForArr())
            {
                Console.Clear();
                Console.WriteLine(textForArray);
                Gen<char> gen = new Gen<char>();

                Int32.TryParse(Console.ReadLine(), out inp);
                bytes = gen.AsArr(inp);

                GetValues(bytes, t);
            }
            break;
        case "float":
            bytes = sizeof(float);
            t = "Float";

            GetValues(bytes, t);
            if (AskForArr())
            {
                Console.Clear();
                Console.WriteLine(textForArray);

                Gen<float> gen = new Gen<float>();
                Int32.TryParse(Console.ReadLine(), out inp);
                bytes = gen.AsArr(inp);

                GetValues(bytes, t);
            }
            break;
        case "double":
            bytes = sizeof(double);
            t = "Double";

            GetValues(bytes, t);
            if (AskForArr())
            {
                Console.Clear();
                Console.WriteLine(textForArray);

                Gen<double> gen = new Gen<double>();
                Int32.TryParse(Console.ReadLine(), out inp);
                bytes = gen.AsArr(inp);

                GetValues(bytes, t);
            }
            break;

        case "end":
            on = false;
            return;

        default:
            return;
    }

    Console.ReadKey();
}

void GetValues(int bytes, string t)
{
    Console.Clear();

    double i = Math.Pow(2, bytes * 8);
    Console.WriteLine($"{t} {bytes}");
    Console.WriteLine($"{t} Max Number of Values: {i}");

    ShowByte(bytes);
}
bool AskForArr()
{
    Console.WriteLine("Want it as an array?");
    //input = Console.ReadLine();
    if (Console.ReadLine().ToLower().Contains("y"))
        return true;
    return false;
}

void ShowByte(int b)
{
    string res = "";
    res += "*------------------*";

    for (int i = 0; i < b; i++)
    {
        res += """

            |      1 byte      |
            *------------------*
            """;

    }
    Console.WriteLine(res);
}


//00, 01, 10, 11 | 0, 1, 2, 3
//000, 001, 010, 100, 101, 110, 111

public class Gen<T>
{
    public int AsArr(int length = 1)
    {
        T[] arr = new T[length];
        return Buffer.ByteLength(arr);
    }
}