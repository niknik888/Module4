

//Task 4.4.2
/*
(string name, int age) anketa;


Console.WriteLine("Enter your name: ");
anketa.name = Console.ReadLine();

Console.WriteLine("Enter your age: ");
anketa.age = int.Parse(Console.ReadLine());


Console.WriteLine("Ваше имя: {0}", anketa.name);
Console.WriteLine("Ваш возраст: {0}", anketa.age);
Console.ReadKey();
*/

//Task 4.4.3
/*
var (name, age) = ("Евгения", 27);

Console.Write("Ваше имя: {0}\n", name);
Console.Write("Ваш возраст: {0}\n", age);

Console.Write("Enter your name: ");
name = Console.ReadLine();

Console.Write("Enter your age: ");
age = int.Parse(Console.ReadLine());


Console.WriteLine("Ваше имя: {0}", name);
Console.WriteLine("Ваш возраст: {0}", age);
Console.ReadKey();
*/

//Task 4.4.5


(string Name, string Type, double Age, int NameCount) Pet;

Console.Write("Enter pet name: ");
Pet.Name = Console.ReadLine();

Console.Write("Enter pet type: ");
Pet.Type = Console.ReadLine();

Console.Write("Enter pet age: ");
Pet.Age = int.Parse(Console.ReadLine());

Pet.NameCount = Pet.Name.Length;
Console.Write($"Pet NameCount is: {Pet.NameCount}");
