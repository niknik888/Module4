//Необходимо разработать методику анкетирования пользователей. Требуется сохранять информацию:
//об имени пользователя, фамилии, логине, длине логина, наличии/отсутствии у пользователя питомца,
//возрасте пользователя, трех любимых цветах пользователя.


using System;

class MainClass
{
    static void Main(string[] args)
    {

        (string name, string lastName, string login, int loginLenght, bool havePet, double age, string[] favcolors) User;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Пользователь {i+1}");
            Console.WriteLine();

            Console.Write("Введите имя: ");
            User.name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            User.lastName = Console.ReadLine();

            Console.Write("Введите логин: ");
            User.login = Console.ReadLine();

            User.loginLenght = User.login.Length;

            Console.Write("Есть ли у вас животные? Да или нет: ");
            string havePet = Console.ReadLine();
            if (havePet.ToLower() == "да") { User.havePet = true; } else { User.havePet = false; }

            Console.Write("Введите возраст: ");
            User.age = int.Parse(Console.ReadLine());

            User.favcolors = new string[3];
            Console.WriteLine("Введите три любимых цвета");
            Console.Write("Цвет 1: ");
            User.favcolors[0] = Console.ReadLine();

            Console.Write("Цвет 2: ");
            User.favcolors[1] = Console.ReadLine();
            Console.Write("Цвет 3: ");
            User.favcolors[2] = Console.ReadLine();

            Console.WriteLine("_________");

        }


    }
}