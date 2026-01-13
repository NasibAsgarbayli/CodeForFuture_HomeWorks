#region C# Introduction

#region Verilmiş n - ededinin 3-e ve 7-e bölünüb-bölünmemesini tapın.

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("Ededi daxil edin:");
//Console.ResetColor();
//int n = Convert.ToInt32(Console.ReadLine());
//if (n % 3 == 0 && n % 7 == 0)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("Eded 3 e ve 7 ye qaliqsiz bolunur.");
//    Console.ResetColor();
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Eded 3 e ve 7 ye qaliqsiz bolunmur.");
//    Console.ResetColor();
//}

#endregion

#region n ve m ededleri verilir. eger n ve m ededleri her ikisi cütdürse n ve m ededlerinin cemini hesablayın.

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("Birinci ededi daxil edin:");
//Console.ResetColor();

//int n = Convert.ToInt32(Console.ReadLine());

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("Ikinci ededi daxil edin:");
//Console.ResetColor();

//int m = Convert.ToInt32(Console.ReadLine());

//if (n % 2 == 0 && m % 2 == 0)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine($"Ededlerin cemi: {n + m}");
//    Console.ResetColor();
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Ededlerden en az biri cut deyil.");
//    Console.ResetColor();
//}

#endregion

#region Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("Birinci ededi daxil edin:");
//Console.ResetColor();

//int n = Convert.ToInt32(Console.ReadLine());

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("Ikinci ededi daxil edin:");
//Console.ResetColor();

//int m = Convert.ToInt32(Console.ReadLine());

//int sum = 0;
//if (n < m)
//{
//    for (int i = n+1; i < m; i++)
//    {
//        if (i % 2 != 0)
//        {
//            sum += i;
//        }
//    }
//    if (sum == 0)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Verdiyiniz araliqda her hansi tek eded yerlesmir.");
//        Console.ResetColor();
//    }
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine($"Tek ededlerin cemi: {sum}");
//    Console.ResetColor();
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("n ededi m ededinden kicik olmalidir.");
//    Console.ResetColor();
//}

#endregion

#region Verilmish arrayin icindeki tek ededlerin cemini tapin.

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.Write("Arrayin element sayini daxil edin: ");
//Console.ResetColor();

//int n = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[n];

//for (int i = 0; i < n; i++)
//{
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.Write($"Element {i + 1}-i daxil edin: ");
//    Console.ResetColor();
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//}

//int sum = 0;
//bool hasOdd = false;

//for (int j = 0; j < n; j++ )
//{
//    if (numbers[j] % 2 != 0)
//    {
//        sum += numbers[j];
//        hasOdd = true;
//    }
//}

//if (hasOdd)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine($"Arraydaki tek ededlerin cemi: {sum}");
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Arrayda hec bir tek eded yoxdur!");
//}
//Console.ResetColor();

#endregion

#region Verilmish arrayin icindeki cut ededlerin sayini tapin.
//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.Write("Arrayin element sayini daxil edin: ");
//Console.ResetColor();

//int n = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[n];

//for (int i = 0; i < n; i++)
//{
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.Write($"Element {i + 1}-i daxil edin: ");
//    Console.ResetColor();
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//}

//int sum = 0;
//bool hasEven = false;

//for (int j = 0; j < n; j++)
//{
//    if (numbers[j] % 2 == 0)
//    {
//        sum += numbers[j];
//        hasEven = true;
//    }
//}

//if (hasEven)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine($"Arraydaki tek ededlerin cemi: {sum}");
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Arrayda hec bir tek eded yoxdur!");
//}
//Console.ResetColor();
#endregion

#endregion

#region Methods, Overriding, Overloading, Ref Parameters

#region Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.Write("ededi daxil edin: ");
//Console.ResetColor();

//int n = Convert.ToInt32(Console.ReadLine());
//bool isPrime = true;

//if (n == 0 || n == 1)
//{
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    Console.WriteLine($"{n} ne sade, ne de mürekkeb ededdir ⚠️");
//}
//else
//{
//    if (n < 0)
//    {
//        Console.ForegroundColor = ConsoleColor.DarkYellow;
//        Console.WriteLine("Menfi ededler üçün sadelik yoxlanmır ⚠️");
//    }
//    else
//    {
//        for (int i = 2; i * i <= n; i++)
//        {
//            if (n % i == 0)
//            {
//                isPrime = false;
//                break;
//            }
//        }

//        if (isPrime)
//        {
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine($"{n} ededi sade ededdir");
//        }
//        else
//        {
//            Console.ForegroundColor = ConsoleColor.Magenta;
//            Console.WriteLine($"{n} ededi mürekkeb ededdir");
//        }
//    }
//}

//Console.ResetColor();

#endregion

#region Overloaded Methods, Ref Parameters
using CodeAcademy_Tasks.Classes_Methods;
using CodeAcademy_Tasks.Helpers;
using CodeAcademy_Tasks.Implementations;
using CodeAcademy_Tasks.Models;
using System;
using System.Collections;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Düzbucaqlının enini daxil edin: ");
//        double a = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Düzbucaqlının uzunluğunu daxil edin: ");
//        double b = Convert.ToDouble(Console.ReadLine());

//        Console.WriteLine($"Düzbucaqlının sahesi: {Area(ref a, ref b)}");

//        Console.Write("Kvadratın terefini daxil edin: ");
//        double side = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine($"Kvadratın sahesi: {Area(ref side)}");

//        Console.Write("Dairenin radiusunu daxil edin: ");
//        double r = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine($"Dairenin sahesi: {Area(r)}");
//    }

//    static double Area(ref double a, ref double b)
//    {
//        return a * b;
//    }

//    static double Area(ref double side)
//    {
//        return side * side;
//    }

//    static double Area(double radius, double PI = 3.14)
//    {
//        return PI * radius * radius;
//    }
//}

#endregion

#region Capitalize Words in a String
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Metni daxil edin: ");
//        string input = Console.ReadLine();
//        string result = CapitalizeWords(input);
//        Console.WriteLine($"Netice: {result}");
//    }

//    static string CapitalizeWords(string input)
//    {
//        string[] words = input.Split(' ');
//        for (int i = 0; i < words.Length; i++)
//        {
//            if (words[i].Length > 0)
//            {
//                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
//            }
//        }
//        return string.Join(" ", words);
//    }
//}
#endregion

#region Delete Special Characters from a String
//class Program2
//{
//    static void Main()
//    {
//        Console.Write("Metni daxil edin: ");
//        string input = Console.ReadLine();
//        string result = RemoveSpecialCharacters(input);
//        Console.WriteLine($"Netice: {result}");
//    }
//    static string RemoveSpecialCharacters(string input)
//    {
//        string result = "";

//        foreach (char ch in input)
//        {
//            if (char.IsLetterOrDigit(ch) || char.IsWhiteSpace(ch))
//            {
//                result += ch;
//            }
//        }

//        return result;
//    }
//}
#endregion

#region Check if a String ends with .com
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Metni daxil edin: ");
//        string input = Console.ReadLine();
//        bool result = EndsWithCom(input);
//        if (result)
//        {
//            Console.WriteLine("Daxil edilen metn .com ile bitir.");
//        }
//        else
//        {
//            Console.WriteLine("Daxil edilen metn .com ile bitmir.");
//        }
//    }
//    static bool EndsWithCom(string input)
//    {
//        return input.EndsWith(".com");
//    }
//}
#endregion

#endregion

#region Array, OOP, Class

//class Program
//{
//    static void Main()
//    {
//        Student student1 = new Student("Leo Merdanly", 20);
//        student1.groupNo = "APA102";
//        student1.GetInfo();
//        Student student2 = new Student("Aslan Mammadzada", 20);
//        student2.groupNo = "APA101";
//        student2.GetInfo();
//    }
//}
//public class Student
//{
//    public string fullName;
//    public int age;
//    public string groupNo;
//    public void GetInfo()
//    {
//        Console.WriteLine($"Full Name: {fullName}, Age: {age}, Group No: {groupNo}");
//    }

//    public Student()
//    {
//        Console.WriteLine("Student Info:");
//    }
//    public Student(string FullName, int Age) : this()
//    {
//        fullName = FullName;
//        age = Age;
//    }
//}


//string[,] array = new string[2, 3]
//{
//    { "A", "B", "C" },
//    { "D", "E", "F" }
//};

//int[] ints = new int[5] { 1, 2, 3, 4, 5 };
//Array.Reverse(ints);
//foreach (var item in ints)
//{
//    Console.Write(item + " ");
//}
#endregion

#region Using Calculate Factorial
//class Program()
//{
//    static void Main()
//    {
//        Factorial factorial = new();
//        Console.WriteLine("Enter the number that you want to calculate factorial for it:");
//        Console.WriteLine($"Result : {factorial.Calculate(Convert.ToInt32(Console.ReadLine()))}");
//    }
//}
#endregion

#region Using Check Correct Info
//Info info = new();
//info.InfoCheck("emil@code.edu.az", "12345");
#endregion

#region Calculation Interface&Method Using
//Calculation calculation = new();

//calculation.Difference(3,5);

//calculation.Divide(5,0);

//calculation.Multiply(-3,-5);

//calculation.Sum(-3, 5);
#endregion

#region Square of number extension using
//int number = 5;
//number.SquareOfNumber();
#endregion

#region Upcasting,Params,Enum,Struct,Nullable

//int? a = 5;
//int b = a ?? 50;


//Eagle eagle = new();
//Animal eagle1 = eagle;


//int input = Convert.ToInt32(Console.ReadLine());
//if (input == 0)
//{
//    Console.WriteLine(Enums.Role1);
//}
//Console.WriteLine(Enums.Role2);
//enum Enums
//{
//    Role1,
//    Role2,
//    Role3,
//    Role4
//}

#endregion

#region K -> C usage
//Celsius c = new Celsius(25);
//Kelvin k = c;
//Console.WriteLine(k.Degree);
#endregion

#region Generic Type Usage
//Pair<int, string> pair1 = new Pair<int, string>(1, "One");
//pair1.Display();

//Pair<string, string> pair2 = new Pair<string, string>("Hello", "World");
//pair2.Display();

//SimpleGenericType<int> intExample = new(52);
//intExample.Print(intExample.RandomValue);

//SimpleGenericType<string> stringExample = new("Hello, Generics");
//stringExample.Print(stringExample.RandomValue);

//SimpleGenericType<double> doubleExample = new(3.14);
//doubleExample.Print(doubleExample.RandomValue);
#endregion

#region Collections Usage
#region List
//List<string> names = new List<string> { "Aslan", "Leyla", "Aslan" };
//names.Add("Aslan");

//foreach (var name in names)
//    Console.WriteLine(name);

//Console.WriteLine($"First name: {names[0]}");
#endregion

#region Hashset
//HashSet<int> numbers = new HashSet<int> { 1, 2, 3, 3 };
//numbers.Add(4);

//foreach (var n in numbers)
//    Console.WriteLine(n);

//Console.WriteLine(numbers.Contains(3));
#endregion

#region SortedList
//SortedList<int, string> sortedList = new();

//sortedList.Add(3, "C");
//sortedList.Add(1, "A");
//sortedList.Add(2, "B");

//foreach (var kvp in sortedList)
//    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
#endregion

#region Hashtable
//Hashtable table = new Hashtable();

//table.Add(1, "A");
//table.Add(2, "B");
//table[3] = "C";

//foreach (DictionaryEntry entry in table)
//{
//    Console.WriteLine($"{entry.Key}: {entry.Value}");
//}

//if (table.ContainsKey(2))
//    Console.WriteLine($"Key 2: {table[2]}");
#endregion
#endregion

#region Delegate
//class Program
//{
//    public delegate bool StringFilter(string str);

//    public static List<string> FilterStrings(List<string> items, StringFilter filter)
//    {
//        List<string> result = new List<string>();

//        foreach (var item in items)
//        {
//            if (filter(item))
//            {
//                result.Add(item);
//            }
//        }

//        return result;
//    }

//    public static void Main()
//    {
//        var words = new List<string> { "apple", "banana", "cherry", "avocado" };

//        var filtered = FilterStrings(words, s => s.StartsWith("a"));

//        foreach (var word in filtered)
//        {
//            Console.WriteLine(word);
//        }
//    }
//}
#endregion

#region User Login Exceptions Usage
//AuthService authService = new();
//authService.Register("Leo","Leo123");
//authService.Login("Leo","Leo123");
#endregion

#region Simple Console App
//using System;
//using System.Collections.Generic;

//namespace AnimalSoundApp
//{
//    interface IAnimal
//    {
//        string Name { get; }
//        void MakeSound();
//    }

//    class Dog : IAnimal
//    {
//        public string Name { get; private set; }

//        public Dog(string name)
//        {
//            Name = name;
//        }

//        public void MakeSound()
//        {
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine($"{Name} says: Woof!");
//            Console.ResetColor();
//        }
//    }

//    class Cat : IAnimal
//    {
//        public string Name { get; private set; }

//        public Cat(string name)
//        {
//            Name = name;
//        }

//        public void MakeSound()
//        {
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            Console.WriteLine($"{Name} says: Meow!");
//            Console.ResetColor();
//        }
//    }

//    class Cow : IAnimal
//    {
//        public string Name { get; private set; }

//        public Cow(string name)
//        {
//            Name = name;
//        }

//        public void MakeSound()
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine($"{Name} says: Moo!");
//            Console.ResetColor();
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<IAnimal> animals = new List<IAnimal>
//            {
//                new Dog("Dog"),
//                new Cat("Cat"),
//                new Cow("Cow")
//            };

//            while (true)
//            {
//                Console.Clear();
//                Console.ForegroundColor = ConsoleColor.White;
//                Console.WriteLine("=== Animal Sound App ===\n");
//                Console.WriteLine("Choose an animal:");
//                Console.WriteLine("1 - Dog");
//                Console.WriteLine("2 - Cat");
//                Console.WriteLine("3 - Cow");
//                Console.WriteLine("0 - Exit");
//                Console.ResetColor();

//                Console.Write("\nEnter your choice: ");
//                string input = Console.ReadLine();

//                Console.WriteLine();

//                switch (input)
//                {
//                    case "1":
//                        animals[0].MakeSound();
//                        break;
//                    case "2":
//                        animals[1].MakeSound();
//                        break;
//                    case "3":
//                        animals[2].MakeSound();
//                        break;
//                    case "0":
//                        Console.ForegroundColor = ConsoleColor.DarkYellow;
//                        Console.WriteLine("Goodbye!");
//                        Console.ResetColor();
//                        return;
//                    default:
//                        Console.ForegroundColor = ConsoleColor.Red;
//                        Console.WriteLine("Invalid choice! Try again.");
//                        Console.ResetColor();
//                        break;
//                }

//                Console.WriteLine("\nPress any key to continue...");
//                Console.ReadKey();
//            }
//        }
//    }
//}
#endregion