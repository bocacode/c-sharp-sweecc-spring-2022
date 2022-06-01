// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

string stranger = "Another";
int one = 1; 

Console.WriteLine($"Hello, {stranger} {one}");

Console.Write(stranger.IndexOf("n").ToString());

int a = 10, b = 20, c = 40;

int sum = a + b + c;

double d = 5.0, e = 2.0;

double div = d / e; 
int max = int.MaxValue;
int maxIsh = max + 3;


Console.WriteLine($"The sum is {sum}");
Console.WriteLine($"what is 70/3 { div }?");

Console.WriteLine($"What is the max of double {double.MaxValue}");
Console.WriteLine($"What is the max of int {int.MaxValue}");

Console.WriteLine($"What is the maxish {maxIsh}");

Console.WriteLine("-------------------------------------------- Array ----------------------");

// int[] arr2 = new int[] {1,2,3,4};
var firstArr = new int[5] {-69, 46, 10, 1, 100};

firstArr[1] = 20; 

for(var i = 0; i < firstArr.Length; i++)
{
    Console.WriteLine($"The value at {i} is {firstArr[i]}");
}

foreach(var el in firstArr)
{
    Console.WriteLine($"The value is {el}");
}


Console.WriteLine("-------------------------------------------- List ----------------------");




