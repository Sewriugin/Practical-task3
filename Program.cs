// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//                                      ПРАКТИЧЕСКОЕ ЗАДАНИЕ 3
// Задача 19: Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
//           1) 14212 -> нет; 2) 23432 -> да; 3) 12821 -> да

// Задача 19
	Console.WriteLine("Задача 19");
	void palindromes(int number)// Метод, который принимает число и проверяет является ли оно палиндромом 
	{        
        int palindrome = number;
        int temp = 0;
        int revers = 0;
        while (palindrome != 0)
        {
            temp = palindrome % 10;
            revers = revers * 10 + temp;
            palindrome = palindrome / 10;
        }
        if (number == revers)
        {
            Console.Write("Число: " + number + " => " + revers + " - является палиндромом ");
        }
        else
        {
            Console.Write("Число: " + number + " => " + revers + " - не является палиндромом ");
        }
        Console.WriteLine();

    }
// вызов метода
	palindromes(number: 14212);// нет
	palindromes(number: 23432);// да
	palindromes(number: 12821);// да


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и  
// находит расстояние между ними в 3D пространстве.
//           1) А(3,6,8); B(2,1,-7) -> 15.84; 2) А(7,-5,0); B(1,-1,9) -> 11.53

// Задача 21
	Console.WriteLine("Задача 21");
    void coordinates()
    {
        Console.Write("Input x1: ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input y1: ");
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input z1: ");
        int z1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input x2: ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input y2: ");
        int y2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input z2: ");
        int z2 = Convert.ToInt32(Console.ReadLine());
        double distanceCoordinates = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        Console.WriteLine("Coordinates " + Math.Round(distanceCoordinates, 2));
    }
    coordinates();

// Задача 23: Напишите программу, которая принимает на вход число N и  
// выдаёт таблицу кубов чисел от 1 до N.
//           1) 3 -> 1, 8, 9; 2) 5 -> 1, 8, 27, 64, 125

// Задача 23
    Console.WriteLine("Задача 23");
    void tableCubes(int numberN)
    {
        int temp = 0;
        int cubes = 1;
        for (int i = 1; i <= numberN; i++)
        {
            temp = i;
            cubes = temp * temp * temp;
            Console.Write(cubes + " ");
        }
        Console.WriteLine();
    }
    Console.Write("Input number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    tableCubes(num);