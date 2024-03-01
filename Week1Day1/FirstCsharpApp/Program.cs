// See https://aka.ms/new-console-template for more information
using System.Net;

Console.WriteLine("Hello, World!");

// Data Types
// What is statically typed language?

// you have to specify  the type of variable or function you want to create


// ======Data Types=======
// Javascript
// == or ===
// var name ="hello"

// Python 
// name = "Hello"

// C#
string name = "Hello";
int number = 7 ;
double dec = 3.14;
float floatValue = 1.2f;
bool isTrue = true;

// Lists and Dictionaries
// Array and List

// Arrays are fixed lenght
string[] groceryList = new string[4];
// [null , null , null , null]
string[] groceryList2 = {"Carrots","Turkey","Bread","Milk"};
//                         0 -------1--------2--------3
// In C#, square brakests are userd for indexing and acessing in a array

groceryList[2] = "Ham";
// [null , null , Ham , null]

// Lists are variable lenght
List<int> numberList = new List<int>();
numberList.Add(3);
numberList.Add(4);
numberList.Add(4);
numberList.Add(5);
numberList.Add(4);
numberList.Add(4);
numberList.Add(3);


// this removes the value of 3
// numberList.Remove(3);
// remove at the location index 3
// numberList.RemoveAt(3);
numberList.Insert(4,100);


foreach(int i in numberList)
{
    Console.WriteLine(i);
}

// string vs Char
// string contains multiple letters
string words="Hello";

// Char only 1 letter
char singleChar ='d';



//===== Function =====

static void SyaHello()
{
    Console.WriteLine("Hi");

}

SyaHello();

//                parameters
static int DoMath(int x, int y)
{
    return x -y;
}

//    arguments
DoMath(10,5);
Console.WriteLine(DoMath(10,4));
int answer = DoMath(10,5);
Console.WriteLine(answer);
