using System.Globalization;

bool on = true;
string textForArray = """
                    How many array spaces?
                    """;

//Console.WriteLine(b.ToString("X")); // For 5 hex numbers


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
            byte bHex = 4;

            GetValues(bytes, t);

            if (AskForArr())
            {
                Console.Clear();
                Console.WriteLine(textForArray);
                Gen<byte> gen = new Gen<byte>();

                Int32.TryParse(Console.ReadLine(), out inp);

                //Console.WriteLine($"{gen.AsArr(inp, sizeof(byte))}");

                GetValues(bytes, t, gen.AsArr(inp, sizeof(byte)), inp);
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

                GetValues(bytes, t, gen.AsArr(inp, sizeof(int)), inp);
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

                GetValues(bytes, t, gen.AsArr(inp, sizeof(char)), inp);
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

                GetValues(bytes, t, gen.AsArr(inp, sizeof(float)), inp);
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

                GetValues(bytes, t, gen.AsArr(inp, sizeof(double)), inp);
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

void GetBits(int bytes)
{
    int res = (bytes * 8);
    Console.WriteLine("In bits: {0} | Calc: {1} * 8", res, bytes);
}

void GetValues(int bytes, string t, long arrVal = 0, int space = 0)
{
    Console.Clear();

    GetBits(bytes);

    if (arrVal == 0)
    {
        //double i = Math.Pow(2, bytes * 8);
        long i = bytes * 8;
        Console.WriteLine($"{t} bytes: {bytes}");
        Console.WriteLine($"{t} Max Number of Values: {i}");
        ShowByte(bytes);
    }
    else
    {
        long arrMaxByte = space * bytes;
        Console.WriteLine($"{t} bytes: {arrMaxByte}");
        Console.WriteLine($"{t} Max Number of Values: {arrMaxByte} and can hold {arrVal} array values with {space} spaces");
        ShowByte((int)arrMaxByte);
    }

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
    public long AsArr(int inp = 1, int size = 1)
    {
        long arrMax = inp * (Convert.ToInt64(Math.Pow(2, size * 8)));
        return arrMax;
    }
}