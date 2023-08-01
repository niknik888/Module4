using System;

class MainClass
{
    public static void Main(string[] args)
    {
        /*
        Console.WriteLine("Цикл do-while");
        int t = 0;

        do
        {


            Console.WriteLine(t);
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            t++;
        } while(t < 3);
        */

        /*
        Console.WriteLine("Цикл while");
        int k = 0;

        while (k < 0)
        {
            Console.WriteLine(k);

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            k++;
        }

        Console.WriteLine("Цикл do");
        int t = 0;

        do
        {
            Console.WriteLine(t);

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            t++;
        } while (t < 0);
        */


        /*

        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();


        Console.WriteLine("Your name on words:");

        foreach (var n in name)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine("Last word on your name: {0}", name[name.Length-1]);

        

        for (int i = name.Length; i > 0;i--)
        {

            Console.Write(name[i-1] + " ");
            

        }

        Console.ReadKey();
        */

        /*
        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };

        foreach (var item in array)
        {
            Console.Write(item + " ");
            
        }
        Console.WriteLine(array.Length);
        */


        /*
        // 4.3.11
        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

        for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
        {
            for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                Console.Write(array[k, i] + " ");

            Console.WriteLine();
        }
        */

        /*
        // 4.3.12 сортировка массива

        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };



        for (int i = 0; i < (arr.Length); i++)
        {
            for (int j = i + 1; j < (arr.Length); j++)
            {
                if (arr[i] > arr[j])
                {
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            

        }

        foreach (int i in arr) { Console.Write(i); }


        // 4.3.13 сумма всех элементов
        Console.WriteLine();

        int sum = 0;
        foreach (int i in arr) { sum += i; }
        Console.WriteLine(sum);
        */

        // Task 4.3.14

        /*
        int[][] array = new int[3][];
        array[0] = new int[2] { 01, 02 };
        array[1] = new int[3] { 11, 12, 13 };
        array[2] = new int[5] { 21, 22, 23, 24, 25 };

        for (int i = 0; i < array.Length; i++) 
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + " ");
            }
            Console.WriteLine();
        }
        

        foreach (var i in array)
        {
            foreach (var j in i)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        */

        /*
        // Task 4.3.15

        int[] array = { 1, -2, 3, -4, 5, -6, 7 };

        int count = 0;

        foreach (int i in array)
        {
            if (i > 0) { count++; }
        }

        Console.WriteLine(count);
        */

        // Task 4.3.16
        /*
        int[,] array = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

        int count = 0;

        foreach (int i in array)
        {
            if (i > 0) { count++; }
        }

        Console.WriteLine(count);
        */


        //Task 4.3.17

        int[,] array = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

        for (int i = 0; i< array.GetLength(0); i++) 
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = j + 1; k< array.GetLength(1); k++)
                {
                    if (array[i, j] > array[i, k])
                    {
                        var temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = temp;
                    }
                }
                
            }           
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }   
        


}



