// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//HW

for (int i = 1; i <= 50; i++)
{
    Console.Write(i);
    if (i % 8 == 0)
    {
        Console.Write(" Nice");
    }
    if (i % 30 == 0)
    {
        Console.Write(" HomeRun!");
    }
    Console.WriteLine();

}
/////

Console.WriteLine("Enter two numers:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1 < num2)
{

    for (int n = num1; n <= num2; n++)
    {
        if (n % 2 == 0)
            Console.WriteLine(n);
    }
}
else if (num1 > num2)
{
    for (int y = num1; y >= num2; y--)
    {
        if (y % 2 != 0)
        {
            Console.WriteLine(y);
        }
    }
}
else { Console.WriteLine("You succeeded to Hack the System"); }








//Console.WriteLine("Please enter two number:");
//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());

//Console.WriteLine("Please chose one of the categories");
//Console.WriteLine("1.Subtract");
//Console.WriteLine("2.Add");
//Console.WriteLine("3.Multiple");
//Console.WriteLine("4.Divide");

//string answer = Console.ReadLine();
//int result = num1 - num2;
//int result2 = num1 + num2;
//int results3 = num1 * num2;
//int resutls4 = num1 / num2;

//while (answer == "")
//{
//    Console.WriteLine("Please chose your option");
//    answer = Console.ReadLine();
//}

//if ((answer == "1") || (answer == "Subtract") || (answer == "subtract"))

//{

//    Console.WriteLine(result);
//}
//if ((answer == "2") || (answer == "Add") || (answer == "add" ))
//{
//    Console.WriteLine(result2);
//}
//if ((answer == "3") || (answer == "Multiple") || (answer == "multiple"))
//{
//    Console.WriteLine(results3);
//}
//if ((answer == "4") || (answer == "Divide") || (answer == "divide"))
//{
//    Console.WriteLine(resutls4);
//}

//Console.WriteLine("Here we can caculate your avarage Score!");
//Console.WriteLine("click Enter to begin");
//Console.ReadLine();
//Console.WriteLine("Math");
//int math = int.Parse(Console.ReadLine());
//while ((math < 0 ) || (math > 100)) 
//{
//    Console.WriteLine("please Enter a proper grade");
//    math = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("English");
//int english = int.Parse(Console.ReadLine());
//while ((english < 0) || (english > 100))
//{
//    Console.WriteLine("please Enter a proper grade");
//    english = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("History");
//int history = int.Parse(Console.ReadLine());
//while ((history < 0) || (history > 100))
//{
//    Console.WriteLine("please Enter a proper grade");
//    history = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Biology");
//int bio = int.Parse(Console.ReadLine());
//while ((bio < 0) || (bio > 100))
//{
//    Console.WriteLine("please Enter a proper grade");
//    bio = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Geography");
//int geo = int.Parse(Console.ReadLine());
//while ((geo < 0) || (geo > 100))
//{
//    Console.WriteLine("please Enter a proper grade");
//    geo = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Caculating.....");
//Thread.Sleep(2000);
//Console.WriteLine((math + english + history + bio + geo) / 5);
