﻿int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c) ;
// subtraction
c = a - b;
Console.WriteLine(c) ;
// multiplication
c = a * b;
Console.WriteLine(c) ;
// division 
c = a / b;
Console.WriteLine(c) ; 
WorkingWithIntegers();
void WorkingWithIntegers()
{    
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c) ;

// subtraction
c = a - b;
Console.WriteLine(c) ;

//multiplication
c = a * b;
Console.WriteLine(c) ;

// division
c = a / b;
Console.WriteLine(c) ;
}

//WorkWithIntegers();
void block(){
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d) ;

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e+f) / g;
    Console.WriteLine(h);
}
// WorkWithIntegers();
OrderPrecedence();

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a +b;
    Console.WriteLine(c);


    // subtraction
    c = a - b;
    Console.WriteLine(c);

    //multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

void OrderPrecedence()
{  
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d= (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}
void errors(){
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

Console.WriteLine(d);
}
double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");


void addons(){
double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
double third = 1.0 / 3.0;
Console.WriteLine(third);

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The rage of decimal type is {min} to {max}");

a = 1.0;
b = 3.0;
Console.WriteLine(a / b);

}
void dec1(){
decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);
}