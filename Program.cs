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
int num = 10; // memory address 1
string name = "Joe";
Assign(ref num, ref name);
Console.WriteLine($"{num}, {name}");

static void Assign(ref int num, ref string name) // this makes a link to the memory address of the variable
{
    num = 20;
    name = "Aba";
}