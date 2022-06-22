using LearnClass;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Test myName = new Test();
            Console.WriteLine(myName.name);
            



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, C#!");


// Data Types
char myChar = 'a';
string stringName = "John";
short age2 = 30;
int age = 30;
double height = 1.78;
decimal decimalWeight = 75.5m;
bool isMarried = false;
float weight = 80.5f;
Console.WriteLine($"This is char {myChar}, string {stringName}, short {age2}, int {age}, double {height}, decimal {decimalWeight}, bool {isMarried}, float {weight}");

// Max and Min

short maxShort = short.MaxValue;
short minShort = short.MinValue;
int maxInt = int.MaxValue;
int minInt = int.MinValue;
long maxLong = long.MaxValue;
long minLong = long.MinValue;
decimal maxDecimal = decimal.MaxValue;
decimal minDecimal = decimal.MinValue;
float maxFloat = float.MaxValue;
float minFloat = float.MinValue;
double maxDouble = double.MaxValue;
double minDouble = double.MinValue;

Console.WriteLine($"Max short {maxShort}, min short {minShort}, max int {maxInt}, min int {minInt}, max long {maxLong}, min long {minLong}, max decimal {maxDecimal}, min decimal {minDecimal}, max float {maxFloat}, min float {minFloat}, max double {maxDouble}, min double {minDouble}");



// Arrays   
int[] numbers = new int[5];
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;
Console.WriteLine($"Array numbers[0] {numbers[0]}, array numbers[1] {numbers[1]}, array numbers[2] {numbers[2]}, array numbers[3] {numbers[3]}, array numbers[4] {numbers[4]}");

// Array with strings
string[] names = new string[5];
names[0] = "John";
names[1] = "Jane";
names[2] = "Mary";
names[3] = "Bob";
names[4] = "Tom";

string[] food = { "Pizza", "Pasta", "Salad", "Soup", "Cake" };

Console.WriteLine($"Array names[0] {names[0]}, array names[1] {names[1]}, array names[2] {names[2]}, array names[3] {names[3]}, array names[4] {names[4]}");

// Loop through array

    for (int i = 0; i < names.Length; i = i+1)
    {
        Console.WriteLine($"Array names[{i}] {names[i]}");
    }

    // Loop through array with foreach

    foreach (string name in names)
    {
        Console.WriteLine($"Array names {name}");
    }

    // Loop through array with for

    int j = 0;
    while (j < names.Length)
    {
        Console.WriteLine($"Array names[{j}] {names[j]}");
        j++;
    }

    // Loop through array with for and if

    for (int i = 0; i < names.Length; i = i+1)
    {
        if (names[i] == "John")
        {
            Console.WriteLine($"Array names[{i}] {names[i]}");
        }
        else if (names[i] == "Jane")
        {
            Console.WriteLine($"Array names[{i}] {names[i]}");
        }
        else if (names[i] == "Mary")
        {
            Console.WriteLine($"Array names[{i}] {names[i]}");
        }
        else if (names[i] == "Bob")
        {
            Console.WriteLine($"Array names[{i}] {names[i]}");
        }
        else if (names[i] == "Tom")
        {
            Console.WriteLine($"Array names[{i}] {names[i]}");
        }
    }



        }
    }
}
