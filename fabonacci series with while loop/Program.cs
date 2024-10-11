// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Reflection.Metadata;

Console.WriteLine("Enter The limit for Series");
int limit = Convert.ToInt32(Console.ReadLine());
if (limit > 0 && limit > 1)
{

    int first = 0;
    Console.WriteLine(first);
    int second = 1;
    Console.WriteLine(second);
    int third = 0;
    while (third < limit)
    {
        third = first + second;
        if (third <= limit)
        {
            Console.WriteLine(third);
            first = second;
            second = third;
        }

    }

}
else
{
    Console.WriteLine("Please Enter the Number Above 0 or 1");

}


