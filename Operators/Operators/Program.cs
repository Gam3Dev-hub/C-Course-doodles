byte a = 100;
byte b = 200;

var c = a + b;
//Console.WriteLine($"Max value of byte: {byte.MaxValue}");
//Console.WriteLine($"Min value of byte: {byte.MinValue}");
//Console.WriteLine(c);

//Console.WriteLine(a);
//Console.WriteLine(b);

/*
checked
{
    //a = (byte)(a + b);
    a += b;
}
*/
/*
a = (byte)((sbyte)a + (sbyte)b);
Console.WriteLine(a);

int d = 10;
int e = 0;
int result;

try
{
    result = d / e;
    Console.WriteLine(result);
}
catch(DivideByZeroException)
{
    Console.WriteLine("Divided by zero exception");
}
result = 0;
Console.WriteLine(result);
*/

Console.WriteLine("Write first number: ");
int val1 = int.Parse(Console.ReadLine());
Console.WriteLine("Write second number: ");
int val2 = int.Parse(Console.ReadLine());
int result = val1 + val2;
Console.WriteLine($"{val1} + val2 = {result}");
result = val1 - val2;
Console.WriteLine($"{val1} - {val2} = {result}");
result = val1 * val2;
Console.WriteLine($"{val1} * {val2} = {result}");
result = val1 / val2;
Console.WriteLine($"{val1} / {val2} = {result}");
result = val1 % val2;
Console.WriteLine($"{val1} % {val2} = {result}");

//Type casting: converting one type of data into another type of data.

//Implicit typecasting
int x = 10;
double y = x;


//explicit typecasting
double d = 10.5;
int e = (int)d;
Console.WriteLine(e);

double g = 10.50008;
int h = Convert.ToInt16(g);
Console.WriteLine(h);


char f = 'A';
int i = (int)f;
Console.WriteLine(i);
string mystring = "hello";
/*
foreach(char car in mystring)
{
    Console.WriteLine(car);
}
*/
/*
for (i = 0; i < mystring.Length; i++)
{

    //Console.WriteLine(mystring.Length);
    Console.WriteLine(mystring[i]);
    int sum1 = (int)mystring[i];
    Console.WriteLine(sum1);
}

*/

Console.WriteLine("Write nominator: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Write denominator: ");
int n2 = int.Parse(Console.ReadLine());
double divisition = (double)n1/n2;
Console.WriteLine($"Division result: {n1} / {n2} = {divisition}");




Console.ReadLine();
