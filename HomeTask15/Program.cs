Console.WriteLine("Input number");
int num1 = Convert.ToInt32 (Console.ReadLine());

if (num1>0 && num1<=7)
{
    if(num1==6 || num1==7)
    {
        Console.WriteLine("Its weekend!");
    }
    else
    {
        Console.WriteLine("Nice day for your Job");
    }
}
else
{
    Console.WriteLine("incorrect number");
}