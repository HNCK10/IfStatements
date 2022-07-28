// See https://aka.ms/new-console-template for more information
//if statement - basic form of decision making
//Some logic to receive a users age
//Console.WriteLine("Please enter your age: ");
//double _age = Convert.ToDouble(Console.ReadLine());
//Check whether the user is 18 or older
//if(_age > 100)
//{
//Console.WriteLine("You are too old to sign up!");
//}
//else if(_age >= 18)
//{
//Console.WriteLine("You are now signed up!");
//}
//else if(_age < 0)
//{
//Console.WriteLine("You haven't been born yet!");
//}
//else
//{
//Console.WriteLine("You must be 18+ to sign up!");
//}
Console.WriteLine("Please enter your name: ");
String name = Console.ReadLine();
if (name== "")
{
    Console.WriteLine("You did not enter your name!");
    name = Console.ReadLine();
    if (name == "")
    {
        Console.WriteLine("You did not enter your name!");
    }
    else
    {
        Console.WriteLine("Hello "+ name);
    }
}
else
{
    Console.WriteLine("Hello "+ name);
}
Console.ReadKey();
