using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using classes;

// Test.TestMessage();

string test = "hello";
string test2 = test.Replace("e", "a");

// STRINGBUILDER
StringBuilder sb = new("Hello, ");
sb.Append("world!");
sb.Insert(7, "beautiful ");
sb.Replace("world", "C#");
sb.Remove(7, 10); // Removes "beautiful"

// Console.WriteLine(sb.ToString()); // Outputs "Hello, C#!"

// FUNCTION PARAMETERS
// functional overloading is when have same name for a function, but can give it different parameters
// static double Add(int a, int b = 0)
// static double Add(int a, int b = default) // gives the default value for the number
// static double Add(int a, [Optional] int b) // gives the default value for the number
// {
//     System.Console.WriteLine(b);
//     return a + b;
// }

// System.Console.WriteLine(Add(5));

// Named parameters
// string nameInput = "Aba";
// int ageInput = 23;
// string addressInput = "1 Something road";

// static void PrintDetails(string name, int age, string address)
// {
//     System.Console.WriteLine($"Name: {name}");
//     System.Console.WriteLine($"Age: {age}");
//     System.Console.WriteLine($"Address: {address}");
// }

// PrintDetails(age:ageInput, name:nameInput, address:addressInput);

// OUT PARAMETERS

// static void testFn(int inNum, out int outNum)
// {
//     outNum = inNum;
// }

// testFn(4, out int outNum); // don't have to specify 'int' bc already declared

// Console.WriteLine($"The number entered is: {outNum}."); //=5

// REFERENCE PARAMETERS
// int num = 10; // memory address 1
// string name = "Joe";
// Assign(ref num, ref name);
// // Console.WriteLine($"{num}, {name}");

// static void Assign(ref int num, ref string name) // this makes a link to the memory address of the variable
// {
//     num = 20;
//     name = "Aba";
// }

// EXERCISE
/*
Ask use for width and height
Store them
Create function to calculate the area
Function should calculate the area using width * height / 2
print out area of triangle
*/

// System.Console.WriteLine("Enter the height of the triangle: ");
// string? stringHeight = Console.ReadLine();
// if (!double.TryParse(stringHeight, out double height))
// {
//     System.Console.WriteLine("Invalid input");
//     return;
// }

// System.Console.WriteLine("Enter the width of the triangle: ");
// string? stringWidth = Console.ReadLine();
// // double width = Convert.ToDouble(stringWidth);
// if (!double.TryParse(stringHeight, out double width))
// {
//     System.Console.WriteLine("Invalid input");
//     return;
// }

// System.Console.WriteLine($"The area of the triangle is: {width * height / 2}");

// static double getInput(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToDouble(Console.ReadLine());
// }

// double height = getInput("Enter height: ");
// double width = getInput("Enter width: ");

// System.Console.WriteLine($"The area of the triangle is: {width * height / 2}");

// Ex 2
/*
Create and initialize int array of numbers
Create function SumOfNumbers with int return type
int array param
function should retrun total of all numbers
output total
extra: check array length
return -1 if array empty
check return in main and output message
do we need to return -1? how else can we make this?
*/

int[] array0 = [3, 4, 5];

// static int SumOfNumbers(int[] array)
// {
//     if (array.Length == 0)
//     {
//         return -1;
//     }
//     else
//     {
//         int answer = 0;
//         foreach(int num in array)
//         {
//             answer += num;
//         }
//         return answer;
//     }
// }

static bool SumOfNumbers(int[] array, out int total)
{
    total = 0;

    if (array.Length == 0)
    {
        return false;
    }
    else
    {
        foreach(int num in array)
        {
            total += num;
        }
        return true;
    }
}

if (SumOfNumbers(array0, out int total))
{
    System.Console.WriteLine($"The total is: {total}");
}
else
{
    System.Console.WriteLine("Array is empty");
}