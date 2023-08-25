// MIS 3033 002
// August 23rd
// Miguel Gallegos 113505460
// simple: int double bool char, not expensive 
// complex: expensive
int age1;// simple
string str1;// complex, pointer, reference 
str1 = new string("mis3033");
age1 = 20;

string str2;
// new string("mis3033");
str2 = "mis3033";

// operators, expression
double r1;
r1 = 100 % 2;
Console.WriteLine(r1);

// comparison
bool r2;
r2 = 3 >= 2;

r2 = 3 == 2;//

r2 = !(3 == 2);

Console.WriteLine(r2);

// = (assignment operator)
// functions
// simple vs complex
// 


// cont
const int age2 = 20;
//age2 = 19;

//
string str3;
Console.WriteLine("Input the grade: ");
str3 = Console.ReadLine();

int age4;// int16 long int 64
// 66666666
// 666
double grade1;
grade1 = Convert.ToDouble(str3);

// string.format()
Console.WriteLine(grade1);

string outMesStr;
outMesStr = string.Format($"The grade is {grade1:P2}");
Console.WriteLine(outMesStr);

// if else statement
// format 1
if (grade1 <= 90)
{
    Console.WriteLine("Congrats! It is A!");
}

// format 2
if (grade1 >= 90)
{
    Console.WriteLine("Congrats it is A!");
}
else
{
    Console.WriteLine("NOT A!");
}

// format 3
if (grade1 >= 90)
{
    Console.WriteLine("A");
}
else if (grade1 >= 80)
{
    Console.WriteLine("B");
}
else if (grade1 >= 70)
{
    Console.WriteLine("C");
}
else
{
    Console.WriteLine("Something Else");
}
// loop
// for
// break: stop the loop
// continue: go straight to post-processing
for (int i = 1; i <= 100; i = i + 1) // i++
{
    if (i == 13 || i == 15 || i == 17)
    {
        continue;
    }
    Console.WriteLine(i);

    if (i >= 20)
    {
        break; // stop the loop
    }
}
// while(){}

int i2;
i2 = 1;

while (i2 < 20)
{
    Console.WriteLine(i2);
    i2 = i2 + 1;
}

i2 = 1;
do
{
    Console.WriteLine(i2);
    i2 = i2 + 1;
}
while (i2 <= 20);

